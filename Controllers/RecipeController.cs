using foodtopia.Database;
using foodtopia.Dtos.Recipe;
using foodtopia.Mappings.Recipes;
using foodtopia.Models;
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
        public async Task<IActionResult> GetAll(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10)
        {
            if (page < 1 || pageSize < 1) return BadRequest(new { Message = "Page and or Page size must be greater than 0." });

            var totalRecipes = await _context.Recipes.CountAsync();

            var recipesDTOs = await _context.Recipes
                .Include(r => r.Country)
                .Include(r => r.User)
                .Include(r => r.Ingredients)
                .Include(r => r.Instructions.OrderBy(ins => ins.Order))
                .Include(r => r.Ratings)
                .OrderBy(r => r.PublishedAt)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(r => r.ToRecipeSummaryDTO())
                .ToListAsync();

            // var recipeDTOs = recipes.Select(r => r.ToRecipeSummaryDTO()).ToList();

            var response = new
            {
                TotalCount = totalRecipes,
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalRecipes / (double)pageSize),
                Recipes = recipesDTOs
            };

            return Ok(response);
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