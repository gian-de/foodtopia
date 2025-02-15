using foodtopia.DTOs.Rating;

namespace foodtopia.Interfaces
{
    public interface IRatingService
    {
        Task<RatingDTO?> GetRatingsAsync(Guid userId, Guid recipeId);
        Task AddOrUpdateRatingsAsync(Guid userId, Guid recipeId, double tasteRating, double difficultyRating);
        Task<bool> DeleteRatingsAsync(Guid userId, Guid recipeId);
    }
}