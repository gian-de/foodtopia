using foodtopia.DTOs.HeartedRecipe;
using foodtopia.Helpers;
using foodtopia.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace foodtopia.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/recipes/hearted-recipes")]
    public class HeartedRecipeController : ControllerBase
    {
        private readonly IHeartedRecipeService _heartedRecipeService;
        public HeartedRecipeController(IHeartedRecipeService heartedRecipeService)
        {
            _heartedRecipeService = heartedRecipeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserHeartedRecipes(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string sortBy = "recent",
            [FromQuery] string sortDirection = "desc"
        )
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Only registered users can favorite recipes.");

                var userId = User.GetUserIdFromClaims();

                var heartedRecipesPagedResult = await _heartedRecipeService.GetUserHeartedRecipeAsync(userId, page, pageSize, sortBy, sortDirection);
                return Ok(heartedRecipesPagedResult);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { ex.Message });
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddHeartedRecipe([FromBody] HeartedRecipeRequestDTO requestDTO)
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Only registered users can favorite recipes.");

                var userId = User.GetUserIdFromClaims();

                await _heartedRecipeService.AddHeartedRecipeAsync(userId, requestDTO.RecipeId);

                return Ok("Recipe hearted successfully!");
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { ex.Message });
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveHeartedRecipe([FromBody] HeartedRecipeRequestDTO requestDTO)
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Only registered users can favorite recipes.");

                var userId = User.GetUserIdFromClaims();

                var removed = await _heartedRecipeService.RemoveHeartedRecipeAsync(userId, requestDTO.RecipeId);

                if (!removed) return NotFound("Recipe not found inside favorites.");

                return Ok("Recipe un-hearted.");
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { ex.Message });
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
    }
}