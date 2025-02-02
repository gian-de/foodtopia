using foodtopia.DTOs.Recipe;
using foodtopia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace foodtopia.Controllers
{
    [Route("api/recipes")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;
        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRecipes(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string sortBy = "PublishedAt",
            [FromQuery] string sortDirection = "desc")
        {
            try
            {
                var pagedResult = await _recipeService.GetAllRecipesAsync(page, pageSize, sortBy, sortDirection);

                return Ok(pagedResult);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetRecipeById([FromRoute] Guid id)
        {
            try
            {
                var recipeDTO = await _recipeService.GetRecipeByIdAsync(id);
                return Ok(recipeDTO);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateRecipe([FromBody] RecipeCreateRequestDTO recipeRequestDTO)
        {
            try
            {
                var recipeDTO = await _recipeService.CreateRecipeAsync(recipeRequestDTO);
                return CreatedAtAction(nameof(GetRecipeById), new { id = recipeDTO.Id }, recipeDTO);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (ArgumentException ex)
            {
                return NotFound(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateRecipe([FromRoute] Guid id, [FromBody] RecipeUpdateRequestDTO recipeRequest)
        {
            try
            {
                var updatedRecipe = await _recipeService.UpdateRecipeAsync(id, recipeRequest);
                return Ok(updatedRecipe);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { ex.Message });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteRecipe([FromRoute] Guid id)
        {
            try
            {
                var deletedRecipeDTO = await _recipeService.DeleteRecipeAsync(id);

                return Ok(new
                {
                    Message = "Recipe successfully deleted.",
                    DeletedRecipe = deletedRecipeDTO
                });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}