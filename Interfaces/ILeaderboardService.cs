using foodtopia.DTOs.Leaderboard;
using foodtopia.DTOs.Recipe;
using foodtopia.Helpers;

namespace foodtopia.Interfaces
{
    public interface ILeaderboardService
    {
        Task<LeaderboardPagedResult<RecipeSummaryDTO>> GetTop100RecipesAsync(int page, int pageSize);
        Task<LeaderboardPagedResult<UserLeaderboardStatsDTO>> GetTop100UsersAsync(int page, int pageSize);
    }
}