using foodtopia.DTOs.Recipe;
using foodtopia.Models;

namespace foodtopia.Interfaces
{
    public interface IHeartedRecipeService
    {
        Task<List<RecipeSummaryDTO>> GetUserHeartedRecipeAsync(AppUser user);
    }
}