using foodtopia.Database;
using foodtopia.DTOs.Recipe;
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
        public async Task<IActionResult> GetAll(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string sortBy = "PublishedAt",
            [FromQuery] string sortDirection = "desc")
        {
            if (page < 1 || pageSize < 1) return BadRequest(new { Message = "Page and or Page size must be greater than 0." });

            var isDescending = sortDirection.ToLower() == "desc";

            var query = _context.Recipes
                .Include(r => r.Country)
                .Include(r => r.User)
                .Include(r => r.Ingredients)
                .Include(r => r.Instructions.OrderBy(ins => ins.Order))
                .Include(r => r.Ratings)
                .AsQueryable();

            query = sortBy.ToLower() switch
            {
                "heartedbyusers" => isDescending
                    ? query.OrderByDescending(r => r.HeartedByUsers.Count)
                    : query.OrderBy(r => r.HeartedByUsers.Count),
                "tasteaverage" => isDescending
                    ? query.OrderByDescending(r => r.Ratings.Average(rt => rt.TasteRating))
                    : query.OrderBy(r => r.Ratings.Average(rt => rt.TasteRating)),
                "difficultyaverage" => isDescending
                    ? query.OrderByDescending(r => r.Ratings.Average(rt => rt.DifficultyRating))
                    : query.OrderBy(r => r.Ratings.Average(rt => rt.DifficultyRating)),
                _ => isDescending
                    ? query.OrderByDescending(r => r.PublishedAt)
                    : query.OrderBy(r => r.PublishedAt)
            };


            var totalRecipes = await query.CountAsync();
            var recipesDTOs = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(r => r.ToRecipeSummaryDTO())
                .ToListAsync();

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
        public async Task<IActionResult> GetById([FromRoute] Guid id)
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

        [HttpPost]
        public async Task<IActionResult> CreateRecipe([FromBody] CreateRecipeRequestDTO recipeRequestDTO)
        {
            if (!ModelState.IsValid) return BadRequest(new { Message = "Invalid request data." });

            var country = await _context.Countries.FindAsync(recipeRequestDTO.CountryId);
            if (country == null) return NotFound(new { Message = "Country associated couldn't be found." });

            // TODO User auth check

            var recipeModel = recipeRequestDTO.ToRecipeFromCreateDTO();
            _context.Recipes.Add(recipeModel);
            await _context.SaveChangesAsync();

            var recipeResponseDTO = recipeModel.ToRecipeSummaryDTO();

            return CreatedAtAction(nameof(GetById), new { id = recipeModel.Id }, recipeResponseDTO);
        }
    }
}