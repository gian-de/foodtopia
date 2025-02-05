using foodtopia.DTOs.Recipe;
using foodtopia.Models;

namespace foodtopia.Interfaces
{
    public interface IHeartedRecipeService
    {
        Task<List<RecipeSummaryDTO>> GetUserHeartedRecipeAsync(AppUser user);
        Task AddHeartedRecipeAsync(AppUser user, Guid recipeId);
        Task<bool> RemoveHeartedRecipeAsync(AppUser user, Guid recipeId);
    }
}