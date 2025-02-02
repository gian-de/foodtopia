using foodtopia.Database;
using foodtopia.DTOs.Recipe;
using foodtopia.Helpers;
using foodtopia.Interfaces;
using foodtopia.Mappings.Recipes;
using Microsoft.EntityFrameworkCore;

namespace foodtopia.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly AppDbContext _context;

        public IngredientService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<RecipeSummaryDTO>> SearchRecipesByIngredientsAsync(
            string[] ingredients,
            int page,
            int pageSize
        )
        {
            if (ingredients is null || ingredients.Length == 0) throw new ArgumentException("At least 1 ingredient must be specified.");
            if (page < 1 || pageSize < 1) throw new ArgumentOutOfRangeException("Page and page size must be greater than 0.");

            var lowercaseIngredients = ingredients.Select(i => i.ToLower()).ToArray();

            var query = _context.Recipes
                .Include(r => r.Country)
                .Include(r => r.User)
                .Include(r => r.Ingredients)
                .Include(r => r.Instructions.OrderBy(ins => ins.Order))
                .Include(r => r.Ratings)
                .Where(r => lowercaseIngredients.All(ing => r.Ingredients.Any(i => i.Name.ToLower().Contains(ing))));

            var totalRecipes = await query.CountAsync();

            var recipes = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            if (!recipes.Any()) throw new KeyNotFoundException($"No recipes found.");

            var recipeDTOs = recipes.Select(r => r.ToRecipeSummaryDTO()).ToList();

            return new PagedResult<RecipeSummaryDTO>
            {
                TotalCount = totalRecipes,
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalRecipes / (double)pageSize),
                Results = recipeDTOs
            };
        }
    }
}