using foodtopia.DTOs.Playlist;
using foodtopia.Helpers;
using foodtopia.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace foodtopia.Controllers
{
    [Route("api/playlists")]
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

        [HttpPost]
        [Authorize]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> CreatePlaylist([FromBody] PlaylistCreateRequestDTO playlistCreateDTO)
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Only registered users can create a playlist");
                var userId = User.GetUserIdFromClaims();
                var createdPlaylist = await _playlistService.CreatePlaylistAsync(userId, playlistCreateDTO);

                return CreatedAtAction(nameof(GetPlaylistById), new { playListId = createdPlaylist.Id }, createdPlaylist);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { ex.Message });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { ex.Message });
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

        [HttpPut("{playlistId:guid}")]
        [Authorize]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> UpdatePlaylist([FromRoute] Guid playlistId, [FromBody] PlaylistUpdateRequestDTO playlistUpdateDTO)
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Only registered users can update a playlist.");
                var userId = User.GetUserIdFromClaims();

                var updatedPlaylist = await _playlistService.UpdatePlaylistAsync(userId, playlistId, playlistUpdateDTO);

                return Ok(updatedPlaylist);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { ex.Message });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { ex.Message });
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

        [HttpDelete("{playlistId:guid}")]
        [Authorize]
        public async Task<IActionResult> DeletePlaylist([FromRoute] Guid playlistId)
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Only registered users can delete a playlist.");
                var userId = User.GetUserIdFromClaims();
                var playlistDeleteDTO = await _playlistService.DeletePlaylistAsync(userId, playlistId);

                return Ok(new
                {
                    Message = "Recipe successfully deleted.",
                    DeletedRecipe = playlistDeleteDTO
                });
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
                return StatusCode(500, ex.Message);
            }
        }
    }
}