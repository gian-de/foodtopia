using foodtopia.Database;
using foodtopia.Dtos.Recipe;
using foodtopia.Mappings.Recipes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace foodtopia.Controllers
{
    [Route("api/recipes")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly AppDbContext _context;
        public RecipeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var recipes = await _context.Recipes
                .Include(r => r.Country)
                .Include(r => r.User)
                .Include(r => r.Ingredients)
                .Include(r => r.Instructions.OrderBy(ins => ins.Order))
                .Include(r => r.Ratings)
                .ToListAsync();

            var recipeDTOs = recipes.Select(r => r.ToRecipeSummaryDTO()).ToList();

            return Ok(recipeDTOs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne([FromRoute] Guid id)
        {

            var recipe = await _context.Recipes
            .Where(r => r.Id == id)
            .Include(r => r.Country)
            .Include(r => r.User)
            .Include(r => r.Ingredients)
            .Include(r => r.Instructions.OrderBy(ins => ins.Order))
            .Include(r => r.Ratings)
            .FirstOrDefaultAsync();

            if (recipe == null) return NotFound(new { Message = $"Recipe with id {id} was not found." });

            var recipeDTO = recipe.ToRecipeSummaryDTO();

            return Ok(recipeDTO);
        }
    }
}