using System.Security.Claims;
using foodtopia.DTOs.HeartedRecipe;
using foodtopia.Extensions;
using foodtopia.Interfaces;
using foodtopia.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace foodtopia.Controllers
{
    [Authorize]
    [Route("api/hearted-recipes")]
    [ApiController]
    public class HeartedRecipeController : Controller
    {
        private readonly IHeartedRecipeService _heartedRecipeService;
        public HeartedRecipeController(IHeartedRecipeService heartedRecipeService)
        {
            _heartedRecipeService = heartedRecipeService;
        }

        private bool IsGuest()
        {
            var isGuestClaimValue = User.FindFirstValue("is_guest");
            if (!bool.TryParse(isGuestClaimValue, out bool isGuest)) throw new UnauthorizedAccessException("Only verified users can favorite recipes.");

            return isGuest;
        }

        private Guid GetUserId()
        {
            var usedIdStr = User.FindFirstValue("user_id");
            if (!Guid.TryParse(usedIdStr, out Guid userId)) throw new UnauthorizedAccessException("Invalid id within JWT.");

            return userId;
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
                if (IsGuest()) return Unauthorized("Only registered users can favorite recipes.");

                var userId = GetUserId();

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
        public async Task<IActionResult> AddHeartedRecipe([FromBody] HeartedRecipeRequestDTO request)
        {
            try
            {
                var userId = GetUserId();

                await _heartedRecipeService.AddHeartedRecipeAsync(userId, request.RecipeId);

                return Ok("Recipe hearted successfully!");
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
        public async Task<IActionResult> RemoveHeartedRecipe([FromBody] HeartedRecipeRequestDTO request)
        {
            try
            {
                var userId = GetUserId();

                var removed = await _heartedRecipeService.RemoveHeartedRecipeAsync(userId, request.RecipeId);

                if (!removed) return NotFound("Recipe not found inside favorites.");

                return Ok("Recipe un-hearted.");
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