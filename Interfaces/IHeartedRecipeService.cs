using foodtopia.DTOs.Recipe;
using foodtopia.Helpers;
using foodtopia.Models;

namespace foodtopia.Interfaces
{
    public interface IHeartedRecipeService
    {
        Task<PagedResult<RecipeSummaryDTO>> GetUserHeartedRecipeAsync(AppUser user, int page, int pageSize, string sortBy, string sortDirection);
        Task AddHeartedRecipeAsync(AppUser user, Guid recipeId);
        Task<bool> RemoveHeartedRecipeAsync(AppUser user, Guid recipeId);
    }
}