using foodtopia.DTOs.Recipe;
using foodtopia.DTOs.Recipe.Submission;
using foodtopia.Helpers;

namespace foodtopia.Interfaces
{
    public interface IRecipeService
    {
        Task<PagedResult<RecipeSummaryDTO>> GetAllRecipesAsync(int page, int pageSize, string sortBy, string sortDirection, string username);
        Task<RecipeSummaryDTO> GetRecipeByIdAsync(Guid recipeId);
        Task<PagedResult<RecipeSummaryDTO>> GetMyCreatedRecipesAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection);
        Task<RecipeSummaryDTO> CreateRecipeAsync(Guid userId, RecipeCreateRequestDTO recipeCreateDTO);
        Task<RecipeSummaryDTO> UpdateRecipeAsync(Guid userId, Guid recipeId, RecipeUpdateRequestDTO recipeUpdateDTO);
        Task<RecipeDeleteDTO> DeleteRecipeAsync(Guid userId, Guid recipeId);

        Task<RecipeSubmissionResponseDTO> SubmitRecipeSubmissionAsync(Guid userId, Guid recipeId);
    };
}