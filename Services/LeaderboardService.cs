using foodtopia.Database;
using foodtopia.DTOs.Leaderboard;
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

        public async Task<LeaderboardPagedResult<UserLeaderboardStatsDTO>> GetTop100UsersAsync(int page, int pageSize)
        {
            if (page < 1 || pageSize < 1) throw new ArgumentException("Page and or Page size must be greater than 0.");

            // EF Core can't translate complex queries like nested projections (like below) entirely in the db. So 1st do a simple projection, the do complex projection in memory.
            // var top100UserQuery = _context.Users
            //                     .Include(u => u.Recipes)
            //                         .ThenInclude(r => r.HeartedByUsers)
            //                     .Select(u => new UserLeaderboardStatsDTO(
            //                                 u.Id,
            //                                 u.UserName,
            //                                 u.Recipes.Count,
            //                                 u.Recipes.Sum(r => r.HeartedByUsers.Count), // aka TotalHeartedRecipeCount
            //                                 u.Recipes
            //                                     .OrderByDescending(r => r.HeartedByUsers.Count)
            //                                     .Select(r => new MostHeartedRecipeNameDTO(r.Id, r.Name))
            //                                     .FirstOrDefault()
            //                     ))
            //                     // rank users by total hearts cumulative 
            //                     .OrderByDescending(u => u.TotalHeartedRecipeCount)
            //                     .Take(100);

            var userData = await _context.Users
                                .Include(u => u.Recipes)
                                    .ThenInclude(r => r.HeartedByUsers)
                                .Select(u => new
                                {
                                    u.Id,
                                    u.UserName,
                                    RecipeCount = u.Recipes.Count,
                                    TotalHeartedRecipeCount = u.Recipes.Sum(r => r.HeartedByUsers.Count),
                                    Recipes = u.Recipes.Select(r => new
                                    {
                                        r.Id,
                                        r.Name,
                                        HeartCount = r.HeartedByUsers.Count
                                    }).ToList()
                                })
                                .OrderByDescending(u => u.TotalHeartedRecipeCount)
                                .Take(100)
                                .ToListAsync();

            var userLeaderboardDTOs = userData.Select(u =>
            {
                var mostHeartedRecipe = u.Recipes.OrderByDescending(r => r.HeartCount).FirstOrDefault();

                var mostHeartedRecipeDTO = mostHeartedRecipe is not null
                                            ? new MostHeartedRecipeNameDTO(mostHeartedRecipe.Id, mostHeartedRecipe.Name)
                                            : null;

                return new UserLeaderboardStatsDTO(
                    u.Id,
                    u.UserName,
                    u.RecipeCount,
                    u.TotalHeartedRecipeCount,
                    mostHeartedRecipeDTO
                );
            }).ToList();

            var pagedTop100Users = userLeaderboardDTOs
                                    .Skip((page - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToList();

            return new LeaderboardPagedResult<UserLeaderboardStatsDTO>
            {
                CurrentPage = page,
                PageSize = pageSize,
                Results = pagedTop100Users
            };
        }
    }
}