using foodtopia.Database;
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
            .Include(r => r.Instructions)
            .Include(r => r.Ratings)
            .ToListAsync();

            var recipeDTOs = recipes.Select(r => r.ToRecipeSummaryDTO()).ToList();

            return Ok(recipeDTOs);
        }

        [HttpGet("{id}")]
        public IActionResult GetOne([FromRoute] int id)
        {
            var recipe = _context.Recipes.Find(id);

            if (recipe == null) return NotFound();

            return Ok(recipe);
        }
    }
}