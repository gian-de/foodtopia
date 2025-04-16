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

        [HttpGet("{fullSlug}")]
        public async Task<IActionResult> GetPlaylistByFullSlug([FromRoute] string fullSlug)
        {
            try
            {
                var playlistDTO = await _playlistService.GetPlaylistByFullSlugAsync(fullSlug);
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

        [Authorize]
        [HttpGet("my")]
        public async Task<IActionResult> GetMyCreatedPlaylists(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string sortBy = "createdAt",
            [FromQuery] string sortDirection = "desc"
        )
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Only registered users are able to make their own playlist.");
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

        [Authorize]
        [HttpPost]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> CreatePlaylist([FromBody] PlaylistCreateRequestDTO playlistCreateDTO)
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Only registered users can create a playlist");
                var userId = User.GetUserIdFromClaims();
                var createdPlaylist = await _playlistService.CreatePlaylistAsync(userId, playlistCreateDTO);

                return CreatedAtAction(nameof(GetPlaylistByFullSlug), new { playListId = createdPlaylist.Id }, createdPlaylist);
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

        [Authorize]
        [HttpPut("{playlistId:guid}")]
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

        [Authorize]
        [HttpDelete("{playlistId:guid}")]
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

        [Authorize]
        [HttpPost("{playlistId:guid}")]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> AddRecipeToPlaylist([FromRoute] Guid playlistId, [FromBody] PlaylistAddRecipeDTO addRecipeDTO)
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Only registered users can utilize playlist features.");

                var userId = User.GetUserIdFromClaims();

                if (addRecipeDTO.recipeId == Guid.Empty) return BadRequest("Recipe id needs to be passed in.");

                await _playlistService.AddRecipeToPlaylistAsync(userId, playlistId, addRecipeDTO.recipeId);

                return Ok("Recipe added to playlist!");
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

        [Authorize]
        [HttpDelete("{playlistId:guid}/{recipeId:guid}")]
        public async Task<IActionResult> DeleteRecipeFromPlaylist([FromRoute] Guid playlistId, [FromRoute] Guid recipeId)
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Playlist feature only available to registered users.");

                var userId = User.GetUserIdFromClaims();

                var removeRecipeFromPlaylist = await _playlistService.RemoveRecipeFromPlaylistAsync(userId, playlistId, recipeId);

                if (!removeRecipeFromPlaylist) return NotFound("Recipe wasn't found in playlist.");

                return Ok("Recipe removed from playlist");
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

        [Authorize]
        [HttpPost("{playlistId:guid}/submissions")]
        public async Task<IActionResult> CreatePlaylistSubmission([FromRoute] Guid playlistId)
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Only registered users can submit a playlist for submission.");
                var userId = User.GetUserIdFromClaims();

                var playlistSubmissionResult = await _playlistService.SubmitPlaylistSubmissionAsync(userId, playlistId);

                return Ok(playlistSubmissionResult);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { ex.Message });
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
                return StatusCode(500, ex.Message);
            }
        }
    }
}