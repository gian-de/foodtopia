using foodtopia.Database;
using foodtopia.DTOs.Recipe;
using foodtopia.Helpers;
using foodtopia.Interfaces;
using foodtopia.Mappings.Recipes;
using Microsoft.EntityFrameworkCore;

namespace foodtopia.Services
{
    public class LeaderboardService : ILeaderboardService
    {
        private readonly AppDbContext _context;
        public LeaderboardService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<LeaderboardPagedResult<RecipeSummaryDTO>> GetTop100RecipesAsync(int page, int pageSize)
        {
            if (page < 1 || pageSize < 1) throw new ArgumentException("Page and or Page size must be greater than 0.");

            var top100RecipeQuery = _context.Recipes
                                    .Include(r => r.Country)
                                    .Include(r => r.User)
                                    .Include(r => r.Ingredients)
                                    .Include(r => r.Instructions.OrderBy(ins => ins.Order))
                                    .Include(r => r.Ratings)
                                    .Include(r => r.HeartedByUsers)
                                    .OrderByDescending(r => r.HeartedByUsers.Count)
                                    .Take(100);

            var pagedTop100Recipes = await top100RecipeQuery
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .Select(r => r.ToRecipeSummaryDTO())
                                .ToListAsync();

            return new LeaderboardPagedResult<RecipeSummaryDTO>
            {
                CurrentPage = page,
                PageSize = pageSize,
                Results = pagedTop100Recipes
            };
        }
    }
}