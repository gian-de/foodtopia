namespace foodtopia.DTOs.Leaderboard
{
    public record UserLeaderboardStatsDTO
    (
        Guid Id,
        string UserName,
        int RecipeCount,
        int TotalHeartedRecipeCount,
        MostHeartedRecipeNameDTO? MostHeartedRecipe
    );
}