using foodtopia.Database;
using foodtopia.DTOs.Rating;
using foodtopia.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace foodtopia.Services
{
    public class RatingService : IRatingService
    {
        private readonly AppDbContext _context;
        public RatingService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<RatingDTO?> GetRatingsAsync(Guid userId, Guid recipeId)
        {
            var ratings = await _context.Ratings
                                    .Where(r => r.RecipeId == recipeId && r.UserId == userId)
                                    .Select(r => new RatingDTO(r.TasteRating, r.DifficultyRating))
                                    .FirstOrDefaultAsync();
            return ratings;
        }
    }
}