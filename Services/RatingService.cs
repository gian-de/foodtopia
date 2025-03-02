using foodtopia.Database;
using foodtopia.DTOs.Rating;
using foodtopia.Helpers;
using foodtopia.Interfaces;
using foodtopia.Mappings.Ratings;
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

        public async Task<PagedResult<RatingByUserDTO>> GetAllMyRatingsAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection)
        {
            if (page < 1 || pageSize < 1) throw new ArgumentException("Page and or Page size must be greater than 0.");

            var userCheck = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (userCheck is null) throw new KeyNotFoundException($"User that was passed to query was not found.");

            bool isDescending = sortDirection.ToLower() == "desc";

            // For RecipeTldr To Mapping, include Country, AppUser, 
            var ratingsQuery = _context.Ratings
                                    .Where(r => r.UserId == userId)
                                    .Include(r => r.Recipe)
                                        .ThenInclude(rec => rec!.Country)
                                    .Include(r => r.Recipe)
                                        .ThenInclude(rec => rec!.User)
                                    .AsQueryable();

            ratingsQuery = sortBy.ToLower() switch
            {
                "reviewedat" => isDescending
                    ? ratingsQuery.OrderByDescending(r => r.ReviewedAt)
                    : ratingsQuery.OrderBy(r => r.ReviewedAt),
                "tasterating" => isDescending
                    ? ratingsQuery.OrderByDescending(r => r.TasteRating)
                    : ratingsQuery.OrderBy(r => r.TasteRating),
                "difficultyrating" => isDescending
                    ? ratingsQuery.OrderByDescending(r => r.DifficultyRating)
                    : ratingsQuery.OrderBy(r => r.DifficultyRating),
                _ => ratingsQuery.OrderByDescending(r => r.ReviewedAt)
            };

            var totalReviews = await _context.Ratings.CountAsync();
            var userRatingsDTO = await ratingsQuery
                                    .Skip((page - 1) * pageSize)
                                    .Take(pageSize)
                                    .Select(r => r.ToRatingByUserDTO())
                                    .ToListAsync();

            return new PagedResult<RatingByUserDTO>
            {
                TotalCount = totalReviews,
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalReviews / (double)pageSize),
                Results = userRatingsDTO
            };
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