using foodtopia.DTOs.Recipe;
using foodtopia.Helpers;

namespace foodtopia.Interfaces
{
    public interface IRecipeService
    {
        Task<PagedResult<RecipeSummaryDTO>> GetAllRecipesAsync(int page, int pageSize, string sortBy, string sortDirection);
        Task<RecipeSummaryDTO> GetRecipeByIdAsync(Guid id);
        Task<RecipeSummaryDTO> CreateRecipeAsync(RecipeCreateRequestDTO recipeRequestDTO);
        Task<RecipeSummaryDTO> UpdateRecipeAsync(Guid id, RecipeUpdateRequestDTO recipeRequest);
        Task<RecipeDeleteDTO> DeleteRecipeAsync(Guid id);
    };
}