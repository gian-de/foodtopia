using foodtopia.DTOs.Rating;

namespace foodtopia.Interfaces
{
    public interface IRatingService
    {
        Task<RatingDTO?> GetRatingsAsync(Guid userId, Guid recipeId);
    }
}