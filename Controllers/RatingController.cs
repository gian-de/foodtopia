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
            var isGuest = User.FindFirstValue("is_guest");

            if (!bool.TryParse(isGuest, out bool guest)) throw new UnauthorizedAccessException("Only verified users can leave ratings.");

            return guest;
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
            if (IsGuest()) return Unauthorized("Only verified users can leave ratings.");
            var userId = GetUserId();
            var ratingsResult = await _ratingService.GetRatingsAsync(userId, recipeId);

            return ratingsResult is not null ? Ok(ratingsResult) : NotFound("No ratings found for this recipe.");
        }
    }
}