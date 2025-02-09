using foodtopia.Database;
using foodtopia.DTOs.Recipe;
using foodtopia.Helpers;
using foodtopia.Interfaces;
using foodtopia.Mappings.Recipes;
using foodtopia.Models;
using Microsoft.EntityFrameworkCore;

namespace foodtopia.Services
{
    public class HeartedRecipeService : IHeartedRecipeService
    {
        private readonly AppDbContext _context;
        public HeartedRecipeService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<PagedResult<RecipeSummaryDTO>> GetUserHeartedRecipeAsync(
            AppUser user,
            int page,
            int pageSize,
            string sortBy,
            string sortDirection)
        {
            if (user is null) throw new ArgumentNullException(nameof(user), "User must be authenticated first!");
            if (page < 1 || pageSize < 1) throw new ArgumentException("Page and or Page size must be greater than 0.");

            bool isDescending = sortDirection.ToLower() == "desc";

            var heartedRecipeQuery = _context.HeartedRecipes
                    .Where(hr => hr.UserId == user.Id)
                    .Include(hr => hr.Recipe)
                        .ThenInclude(r => r.HeartedByUsers) // needed to get "HeartedAt" prop for sort functionality
                    .Include(hr => hr.Recipe.Country)
                    .Include(hr => hr.Recipe.Ingredients)
                    .Include(hr => hr.Recipe.Instructions)
                    .Include(hr => hr.Recipe.Ratings)
                    .Select(hr => hr.Recipe)
                    .AsQueryable();

            heartedRecipeQuery = sortBy.ToLower() switch
            {
                "heartedbyusers" => isDescending
                    ? heartedRecipeQuery.OrderByDescending(r => r.HeartedByUsers.Count)
                    : heartedRecipeQuery.OrderBy(r => r.HeartedByUsers.Count),
                "tasteaverage" => isDescending
                    ? heartedRecipeQuery.OrderByDescending(r => r.Ratings.Average(rt => rt.TasteRating))
                    : heartedRecipeQuery.OrderBy(r => r.Ratings.Average(rt => rt.TasteRating)),
                "difficultyaverage" => isDescending
                    ? heartedRecipeQuery.OrderByDescending(r => r.Ratings.Average(rt => rt.DifficultyRating))
                    : heartedRecipeQuery.OrderBy(r => r.Ratings.Average(rt => rt.DifficultyRating)),
                _ => isDescending
                    ? heartedRecipeQuery.OrderByDescending(r => r.HeartedByUsers.Max(hr => hr.HeartedAt))
                    : heartedRecipeQuery.OrderBy(r => r.HeartedByUsers.Max(hr => hr.HeartedAt))
            };

            var totalCount = await heartedRecipeQuery.CountAsync();
            var heartedRecipePagination = await heartedRecipeQuery
                                    .Skip((page - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            var heartedRecipesDTO = heartedRecipePagination.Select(r => r.ToRecipeSummaryDTO()).ToList();

            return new PagedResult<RecipeSummaryDTO>
            {
                TotalCount = totalCount,
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize),
                Results = heartedRecipesDTO
            };
        }

        public async Task AddHeartedRecipeAsync(AppUser user, Guid recipeId)
        {
            var recipe = await _context.Recipes.FindAsync(recipeId);
            if (recipe is null) throw new ArgumentNullException("Recipe not found.");

            bool alreadyHearted = await _context.HeartedRecipes
                                            .AnyAsync(hr => hr.UserId == user.Id && hr.RecipeId == recipeId);

            if (alreadyHearted) throw new ArgumentException("You've hearted this recipe already.");

            var heartedRecipe = new HeartedRecipe
            {
                UserId = user.Id,
                RecipeId = recipeId,
            };

            await _context.HeartedRecipes.AddAsync(heartedRecipe);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> RemoveHeartedRecipeAsync(AppUser user, Guid recipeId)
        {
            var heartedRecipe = await _context.HeartedRecipes
                                    .FirstOrDefaultAsync(hr => hr.UserId == user.Id && hr.RecipeId == recipeId);

            if (heartedRecipe is null) return false;

            _context.HeartedRecipes.Remove(heartedRecipe);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}