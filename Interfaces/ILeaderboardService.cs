using foodtopia.DTOs.Recipe;
using foodtopia.Helpers;

namespace foodtopia.Interfaces
{
    public interface ILeaderboardService
    {
        Task<LeaderboardPagedResult<RecipeSummaryDTO>> GetTop100RecipesAsync(int page, int pageSize);
    }
}