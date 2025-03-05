using foodtopia.DTOs.Rating;
using foodtopia.Helpers;
using foodtopia.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace foodtopia.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/recipes")]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;
        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpGet("ratings/my")]
        public async Task<IActionResult> GetAllMyRatings(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string sortBy = "reviewedat",
            [FromQuery] string sortDirection = "desc"
        )
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Only verified users can leave ratings.");
                var userId = User.GetUserIdFromClaims();
                var myRatingsPagedResult = await _ratingService.GetAllMyRatingsAsync(userId, page, pageSize, sortBy, sortDirection);
                
                return Ok(myRatingsPagedResult);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { ex.Message });
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

        [HttpGet("{recipeId:guid}/ratings")]
        public async Task<IActionResult> GetRatingsAsync(Guid recipeId)
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Only verified users can leave ratings.");
                var userId = User.GetUserIdFromClaims();
                var ratingDTO = await _ratingService.GetRatingsAsync(userId, recipeId);

                return ratingDTO is not null ? Ok(ratingDTO) : NotFound("No ratings found for this recipe.");
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

        [HttpPost("{recipeId:guid}/ratings")]
        public async Task<IActionResult> AddOrUpdateRatings(Guid recipeId, [FromBody] RatingCreateDTO ratingRequestDTO)
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Only verified users can leave ratings.");
                var userId = User.GetUserIdFromClaims();
                await _ratingService.AddOrUpdateRatingsAsync(userId, recipeId, ratingRequestDTO.TasteRating, ratingRequestDTO.DifficultyRating);

                return Ok("Ratings saved!");
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

        [HttpDelete("{recipeId:guid}/ratings")]
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