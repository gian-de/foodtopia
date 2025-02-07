using foodtopia.Database;
using foodtopia.DTOs.Recipe;
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
        public async Task<List<RecipeSummaryDTO>> GetUserHeartedRecipeAsync(AppUser user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user), "User must be authenticated first!");

            // since ToRecipeSummaryDTO() is only usable in memory, first load entities then map to DTO
            var recipes = await _context.HeartedRecipes
                    .Where(hr => hr.UserId == user.Id)
                    .Include(hr => hr.Recipe)
                        .ThenInclude(r => r.HeartedByUsers)
                    .Include(hr => hr.Recipe.Country)
                    .Include(hr => hr.Recipe.Ingredients)
                    .Include(hr => hr.Recipe.Instructions)
                    .Include(hr => hr.Recipe.Ratings)
                    .Select(hr => hr.Recipe)
                    .ToListAsync();

            return recipes.Select(r => r.ToRecipeSummaryDTO()).ToList();
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