using foodtopia.Database;
using foodtopia.Mappings.Recipes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace foodtopia.Controllers
{
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly AppDbContext _context;
        public IngredientController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet("api/search-by-ingredients")]
        public async Task<IActionResult> SearchByIngredients(
            [FromQuery] string[] ingredients,
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10)
        {
            if (ingredients == null || ingredients.Length == 0) return BadRequest(new { Message = "At least 1 ingredient must be specified." });
            if (page < 1 || pageSize < 1) return BadRequest(new { Message = "Page and page size must be greater than 0." });

            var lowercaseIngredients = ingredients.Select(i => i.ToLower()).ToArray();

            var totalRecipes = await _context.Recipes
                .Where(r => lowercaseIngredients.All(ing => r.Ingredients.Any(i => i.Name.Contains(ing))))
                .CountAsync();

            var recipes = await _context.Recipes
                .Include(r => r.Country)
                .Include(r => r.User)
                .Include(r => r.Ingredients)
                .Include(r => r.Instructions.OrderBy(ins => ins.Order))
                .Include(r => r.Ratings)
                .Where(r => lowercaseIngredients.All(ing => r.Ingredients.Any(i => i.Name.ToLower().Contains(ing))))
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            if (recipes == null) return NotFound(new { Message = $"No recipes found..." });

            var recipeDTOs = recipes.Select(r => r.ToRecipeSummaryDTO()).ToList();

            return Ok(
                new
                {
                    TotalCount = totalRecipes,
                    CurrentPage = page,
                    PageSize = pageSize,
                    TotalPages = (int)Math.Ceiling(totalRecipes / (double)pageSize),
                    Recipes = recipeDTOs
                }
            );
        }
    }
}