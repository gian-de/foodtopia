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

        [HttpGet]
        public async Task<IActionResult> GetAllPlaylists(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string sortBy = "heartedByCount",
            [FromQuery] string sortDirection = "desc"
        )
        {
            try
            {
                var playlistResults = await _playlistService.GetAllPlaylistsAsync(page, pageSize, sortBy, sortDirection);
                return Ok(playlistResults);
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

        [HttpGet("{playlistId:guid}")]
        public async Task<IActionResult> GetPlaylistById([FromRoute] Guid playlistId)
        {
            try
            {
                var playlistDTO = await _playlistService.GetPlaylistByIdAsync(playlistId);
                return Ok(playlistDTO);
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