using foodtopia.DTOs.Recipe;
using foodtopia.Helpers;

namespace foodtopia.Interfaces
{
    public interface IRecipeService
    {
        Task<PagedResult<RecipeSummaryDTO>> GetAllRecipesAsync(int page, int pageSize, string sortBy, string sortDirection);
        Task<RecipeSummaryDTO> GetRecipeByIdAsync(Guid recipeId);
        Task<RecipeSummaryDTO> CreateRecipeAsync(Guid userId, RecipeCreateRequestDTO recipeRequestDTO);
        Task<RecipeSummaryDTO> UpdateRecipeAsync(Guid userId, Guid recipeId, RecipeUpdateRequestDTO recipeRequest);
        Task<RecipeDeleteDTO> DeleteRecipeAsync(Guid userId, Guid recipeId);
    };
}