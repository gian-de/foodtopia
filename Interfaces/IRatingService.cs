using foodtopia.DTOs.Rating;
using foodtopia.Helpers;

namespace foodtopia.Interfaces
{
    public interface IRatingService
    {
        Task<PagedResult<RatingByUserDTO>> GetAllMyRatingsAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection);
        Task<RatingDTO?> GetRatingsAsync(Guid userId, Guid recipeId);
        Task AddOrUpdateRatingsAsync(Guid userId, Guid recipeId, double tasteRating, double difficultyRating);
        Task<bool> DeleteRatingsAsync(Guid userId, Guid recipeId);
    }
}