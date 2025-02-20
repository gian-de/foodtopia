using foodtopia.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace foodtopia.Controllers
{
    [Route("api/leaderboard")]
    public class LeaderboardController : ControllerBase
    {
        private readonly ILeaderboardService _leaderboardService;
        public LeaderboardController(ILeaderboardService leaderboardService)
        {
            _leaderboardService = leaderboardService;
        }

        [HttpGet("recipes")]
        public async Task<IActionResult> GetTop100Recipes([FromQuery] int page = 1)
        {
            try
            {
                var pageSize = 50;
                var top100RecipesResult = await _leaderboardService.GetTop100RecipesAsync(page, pageSize);

                return Ok(top100RecipesResult);
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

        [HttpGet("users")]
        public async Task<IActionResult> GetTop100Users([FromQuery] int page = 1)
        {
            try
            {
                int pageSize = 50;

                var top100UsersResult = await _leaderboardService.GetTop100UsersAsync(page, pageSize);
                return Ok(top100UsersResult);
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
    }
}