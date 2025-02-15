using foodtopia.Database;
using foodtopia.DTOs.Rating;
using foodtopia.Interfaces;
using foodtopia.Models;
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
            return await _context.Ratings
                                    .Where(r => r.RecipeId == recipeId && r.UserId == userId)
                                    .Select(r => new RatingDTO(r.TasteRating, r.DifficultyRating))
                                    .FirstOrDefaultAsync();

        }

        public async Task AddOrUpdateRatingsAsync(Guid userId, Guid recipeId, double tasteRating, double difficultyRating)
        {
            var existingRatings = await _context.Ratings
                                    .FirstOrDefaultAsync(r => r.UserId == userId && r.RecipeId == recipeId);

            if (existingRatings is not null)
            {
                existingRatings.TasteRating = tasteRating;
                existingRatings.DifficultyRating = difficultyRating;
                await _context.SaveChangesAsync();
                return;
            }

            var newRating = new Rating
            {
                UserId = userId,
                RecipeId = recipeId,
                TasteRating = tasteRating,
                DifficultyRating = difficultyRating
            };

            await _context.Ratings.AddAsync(newRating);
            await _context.SaveChangesAsync();
        }


        public async Task<bool> DeleteRatingsAsync(Guid userId, Guid recipeId)
        {
            var existingRatings = await _context.Ratings
                                    .FirstOrDefaultAsync(r => r.UserId == userId && r.RecipeId == recipeId);

            if (existingRatings is null) return false;

            _context.Ratings.Remove(existingRatings);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}