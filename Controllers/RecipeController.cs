using foodtopia.Database;
using foodtopia.DTOs.Recipe;
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
        public async Task<IActionResult> GetAllRecipes(
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

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetRecipeById([FromRoute] Guid id)
        {

            var recipe = await _context.Recipes
            .Where(r => r.Id == id)
            .Include(r => r.Country)
            .Include(r => r.User)
            .Include(r => r.Ingredients)
            .Include(r => r.Instructions.OrderBy(ins => ins.Order))
            .Include(r => r.Ratings)
            .FirstOrDefaultAsync();

            if (recipe is null) return NotFound(new { Message = $"Recipe with id {id} was not found." });

            var recipeDTO = recipe.ToRecipeSummaryDTO();

            return Ok(recipeDTO);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRecipe([FromBody] RecipeCreateRequestDTO recipeRequestDTO)
        {
            if (!ModelState.IsValid) return BadRequest(new { Message = "Invalid request data." });

            var country = await _context.Countries.FindAsync(recipeRequestDTO.CountryId);
            if (country is null) return NotFound(new { Message = "Country associated couldn't be found." });

            // TODO User auth check

            var recipeModel = recipeRequestDTO.ToRecipeFromCreateDTO();
            _context.Recipes.Add(recipeModel);
            await _context.SaveChangesAsync();

            var recipeResponseDTO = recipeModel.ToRecipeSummaryDTO();

            return CreatedAtAction(nameof(GetRecipeById), new { id = recipeModel.Id }, recipeResponseDTO);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateRecipe([FromRoute] Guid id, [FromBody] RecipeUpdateRequestDTO recipeRequest)
        {
            if (recipeRequest is null) return BadRequest(new { Message = "Recipe data is required." });

            var recipeModel = await _context.Recipes
                .Include(r => r.Instructions)
                .Include(r => r.Instructions)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (recipeModel is null) return NotFound(new { Message = $"Recipe with Id {id} was not found." });

            // Check fields provided in recipeRequest, if true -> update 
            if (!string.IsNullOrWhiteSpace(recipeRequest.Name))
            {
                recipeModel.Name = recipeRequest.Name;
            }

            if (recipeRequest.CountryId.HasValue && recipeRequest.CountryId.Value != recipeModel.CountryId)
            {
                // check if CountryId exists
                var countryExists = await _context.Countries.AnyAsync(c => c.Id == recipeRequest.CountryId.Value);

                if (!countryExists) return BadRequest(new { Message = $"Country Id provided does not exist: {recipeRequest.CountryId.Value}" });

                recipeModel.CountryId = recipeRequest.CountryId.Value;
            }

            if (!string.IsNullOrWhiteSpace(recipeRequest.ImageUrl))
            {
                recipeModel.ImageUrl = recipeRequest.ImageUrl;
            }

            if (recipeRequest.Ingredients != null && recipeRequest.Ingredients.Any())
            {
                _context.Ingredients.RemoveRange(recipeModel.Ingredients);
                // map requestDTO to recipeModel -> insert to db
                recipeModel.Ingredients = recipeRequest.Ingredients.Select(ing => new Ingredient
                {
                    Name = ing.Name,
                    Quantity = ing.Quantity,
                    Measurement = ing.Measurement
                }).ToList();
            }

            if (recipeRequest.Instructions != null && recipeRequest.Instructions.Count() > 0)
            {
                _context.Instructions.RemoveRange(recipeModel.Instructions);
                // map requestDTO to recipeModel -> insert to db
                recipeModel.Instructions = recipeRequest.Instructions.Select(ins => new Instruction
                {
                    Order = ins.Order,
                    Text = ins.Text
                }).ToList();
            }

            await _context.SaveChangesAsync();

            // refetch the updated Recipe
            var updatedRecipeModel = await _context.Recipes
                .Include(r => r.Country)
                .Include(r => r.User)
                .Include(r => r.Ingredients)
                .Include(r => r.Instructions.OrderBy(ins => ins.Order))
                .Include(r => r.Ratings)
                .FirstOrDefaultAsync(r => r.Id == id);

            // map updated Recipe Model back to DTO
            var updatedRecipeDTO = updatedRecipeModel?.ToRecipeSummaryDTO();

            return Ok(updatedRecipeDTO);
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteRecipe([FromRoute] Guid id)
        {
            var recipeModel = await _context.Recipes
                .Include(r => r.Country)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (recipeModel is null) return NotFound(new { Message = $"Recipe with ID {id} was not found." });

            _context.Recipes.Remove(recipeModel);
            await _context.SaveChangesAsync();

            var deletedRecipeDTO = new RecipeDeleteDTO
            (
                recipeModel.Name,
                recipeModel.Country!.Name
            );

            return Ok(new
            {
                Message = "Recipe successfully deleted.",
                DeletedRecipe = deletedRecipeDTO
            });
        }
    }
}