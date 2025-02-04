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
    }
}