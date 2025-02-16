using foodtopia.DTOs.Rating;
using foodtopia.Helpers;
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

        [HttpGet]
        public async Task<IActionResult> GetRatingsAsync(Guid recipeId)
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Only verified users can leave ratings.");
                var userId = User.GetUserIdFromClaims();
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

        [HttpPost]
        public async Task<IActionResult> AddOrUpdateRatings(Guid recipeId, [FromBody] RatingCreateDTO ratingRequestDTO)
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Only verified users can leave ratings.");
                var userId = User.GetUserIdFromClaims();
                await _ratingService.AddOrUpdateRatingsAsync(userId, recipeId, ratingRequestDTO.TasteRating, ratingRequestDTO.DifficultyRating);

                return Ok("Rating saved!");
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

        [HttpDelete]
        public async Task<IActionResult> DeleteRatings(Guid recipeId)
        {
            if (User.IsGuest()) return Unauthorized("Only verified users can leave ratings.");
            var userId = User.GetUserIdFromClaims();

            var removeRatings = await _ratingService.DeleteRatingsAsync(userId, recipeId);
            if (!removeRatings) return NotFound("Ratings not found for this given recipe");

            return Ok("Ratings deleted!");
        }
    }
}