using System.Security.Claims;
using foodtopia.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace foodtopia.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/recipes/{recipeId:guid}/ratings")]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;
        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        private bool IsGuest()
        {
            var isGuestClaimValue = User.FindFirstValue("is_guest");

            if (!bool.TryParse(isGuestClaimValue, out bool isGuest)) throw new UnauthorizedAccessException("Only verified users can leave ratings.");

            return isGuest;
        }
        private Guid GetUserId()
        {
            var userIdStr = User.FindFirstValue("user_id");
            // parse from type string to Guid (AppUser's id type set inside Model)
            if (!Guid.TryParse(userIdStr, out Guid userId)) throw new UnauthorizedAccessException("Invalid id within JWT");

            return userId;
        }

        [HttpGet]
        public async Task<IActionResult> GetRatingsAsync(Guid recipeId)
        {
            try
            {
                if (IsGuest()) return Unauthorized("Only verified users can leave ratings.");
                var userId = GetUserId();
                var ratingsResult = await _ratingService.GetRatingsAsync(userId, recipeId);

                return ratingsResult is not null ? Ok(ratingsResult) : NotFound("No ratings found for this recipe.");
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }
    }
}