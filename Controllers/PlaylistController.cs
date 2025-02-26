using foodtopia.Helpers;
using foodtopia.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace foodtopia.Controllers
{
    [Route("api/playlist")]
    public class PlaylistController : ControllerBase
    {
        private readonly IPlaylistService _playlistService;
        public PlaylistController(IPlaylistService playlistService)
        {
            _playlistService = playlistService;
        }

        [HttpGet("my")]
        [Authorize]
        public async Task<IActionResult> GetMyCreatedPlaylists(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string sortBy = "createdAt",
            [FromQuery] string sortDirection = "desc"
        )
        {
            try
            {
                var userId = User.GetUserIdFromClaims();

                var myPlaylistPagedResult = await _playlistService.GetMyCreatedPlaylistsAsync(userId, page, pageSize, sortBy, sortDirection);

                return Ok(myPlaylistPagedResult);
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