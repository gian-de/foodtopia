using foodtopia.DTOs.Recipe;
using foodtopia.Helpers;

namespace foodtopia.Interfaces
{
    public interface IHeartedRecipeService
    {
        Task<PagedResult<RecipeSummaryDTO>> GetUserHeartedRecipeAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection);
        Task AddHeartedRecipeAsync(Guid userId, Guid recipeId);
        Task<bool> RemoveHeartedRecipeAsync(Guid userId, Guid recipeId);
    }
}