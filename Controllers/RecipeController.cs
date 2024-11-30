
using foodtopia.Database;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetAll()
        {
            var recipes = _context.Recipes.ToList();

            return Ok(recipes);
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var recipe = _context.Recipes.Find(id);

            if (recipe == null) return NotFound();

            return Ok(recipe);
        }
    }
}