using System.Security.Claims;
using foodtopia.DTOs.Recipe;
using foodtopia.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

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

        private Guid GetUserId()
        {
            var userIdStr = User.FindFirstValue("user_id");
            // parse from type string to Guid (AppUser's id type set inside Model)
            if (!Guid.TryParse(userIdStr, out Guid userId)) throw new UnauthorizedAccessException("Invalid id within JWT");

            return userId;
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
                var recipePagedResult = await _recipeService.GetAllRecipesAsync(page, pageSize, sortBy, sortDirection);

                return Ok(recipePagedResult);
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

        [HttpGet("{recipeId:guid}")]
        public async Task<IActionResult> GetRecipeById([FromRoute] Guid recipeId)
        {
            try
            {
                var recipeDTO = await _recipeService.GetRecipeByIdAsync(recipeId);
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

        [Authorize]
        [HttpPost]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> CreateRecipe([FromBody] RecipeCreateRequestDTO recipeRequestDTO)
        {
            try
            {
                var userId = GetUserId();
                var recipeDTO = await _recipeService.CreateRecipeAsync(userId, recipeRequestDTO);
                return CreatedAtAction(nameof(GetRecipeById), new { recipeId = recipeDTO.Id }, recipeDTO);
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

        [Authorize]
        [HttpPut("{recipeId:guid}")]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> UpdateRecipe([FromRoute] Guid recipeId, [FromBody] RecipeUpdateRequestDTO recipeRequest)
        {
            try
            {
                var userId = GetUserId();
                var updatedRecipe = await _recipeService.UpdateRecipeAsync(userId, recipeId, recipeRequest);
                return Ok(updatedRecipe);
            }
            catch (UnauthorizedAccessException)
            {
                return Forbid();
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

        [Authorize]
        [HttpDelete("{recipeId:guid}")]
        public async Task<IActionResult> DeleteRecipe([FromRoute] Guid recipeId)
        {
            try
            {
                var userId = GetUserId();
                var deletedRecipeDTO = await _recipeService.DeleteRecipeAsync(userId, recipeId);

                return Ok(new
                {
                    Message = "Recipe successfully deleted.",
                    DeletedRecipe = deletedRecipeDTO
                });
            }
            catch (UnauthorizedAccessException)
            {
                return Forbid();
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