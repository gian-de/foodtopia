using foodtopia.DTOs.Admin;
using foodtopia.DTOs.Admin.Moderator;
using foodtopia.Helpers;
using foodtopia.Interfaces.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace foodtopia.Controllers
{
    [ApiController]
    [Route("api")]
    public class AdminController : ControllerBase
    {
        private readonly ISeniorAdminService _seniorAdminService;
        private readonly IModeratorService _moderatorService;
        public AdminController(ISeniorAdminService seniorAdminService, IModeratorService moderatorService)
        {
            _seniorAdminService = seniorAdminService;
            _moderatorService = moderatorService;
        }
        // ONLY 'Senior Admin' endpoints START - Normal Admin endpoints further below 
        // [Authorize(Roles = "Senior Admin")]
        [Authorize(Roles = "Owner, Senior Admin")]
        [HttpGet("senior-admin/admins")]
        public async Task<IActionResult> GetAllAdmins([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            try
            {
                var admins = await _seniorAdminService.GetAllBothSeniorAndAdminsAsync(page, pageSize);
                return Ok(admins);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [Authorize(Roles = "Owner, Senior Admin")]
        [HttpGet("senior-admin/senior-admins")]
        public async Task<IActionResult> GetAllSeniorAdmins([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            try
            {
                var seniorAdmins = await _seniorAdminService.GetAllSeniorAdminsAsync(page, pageSize);
                return Ok(seniorAdmins);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [Authorize(Roles = "Owner, Senior Admin")]
        [HttpGet("senior-admin/non-senior-admins")]
        public async Task<IActionResult> GetAllNonSeniorAdmins([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            try
            {
                var nonSeniorAdmins = await _seniorAdminService.GetAllNonSeniorAdminsAsync(page, pageSize);
                return Ok(nonSeniorAdmins);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [Authorize(Roles = "Owner, Senior Admin")]
        [HttpPost("senior-admin/admins")]
        public async Task<IActionResult> AddAdminRole([FromBody] AddAdminRoleDTO dto)
        {
            try
            {
                var result = await _seniorAdminService.AddAdminRoleAsync(dto.userId);
                return Ok(result);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { ex.Message });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [Authorize(Roles = "Owner, Senior Admin")]
        [HttpDelete("senior-admin/admins/{userId:guid}")]
        public async Task<IActionResult> RemoveAdminRole([FromRoute] Guid userId)
        {
            try
            {
                var resultSuccess = await _seniorAdminService.RemoveAdminRoleAsync(userId);

                if (!resultSuccess) return BadRequest("User wasn't able to be unmodded.");

                return Ok(new { Message = "User has been remove as Admin successfully." });
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
        // ONLY Senior Admins endpoints END

        // ALL Admins endpoints START
        [Authorize(Roles = "Owner, Senior Admin, Admin")]
        [HttpGet("moderator/recipes/pending")]
        public async Task<IActionResult> GetAllRecipePendingSubmissions(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string? username = null)
        {
            try
            {
                var pendingRecipesResult = await _moderatorService.GetAllRecipePendingSubmissionsAsync(page, pageSize, username);

                return Ok(pendingRecipesResult);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return BadRequest(new { ex.Message });
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

        [Authorize(Roles = "Owner, Senior Admin, Admin")]
        [HttpPost("moderator/recipes/{recipeId:guid}/submission")]
        public async Task<IActionResult> ReviewRecipeSubmission([FromRoute] Guid recipeId, [FromBody] ModeratorSubmissionReviewDTO recipeReviewDTO)
        {
            try
            {
                var adminId = User.GetUserIdFromClaims();

                var recipeReviewResponse = await _moderatorService.RecipeSubmissionReviewAsync(adminId, recipeId, recipeReviewDTO);

                return Ok(recipeReviewResponse);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { ex.Message });
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

        [Authorize(Roles = "Owner, Senior Admin, Admin")]
        [HttpGet("moderator/playlists/pending")]
        public async Task<IActionResult> GetAllPlaylistPendingSubmissions(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string? username = null)
        {
            try
            {
                var pendingPlaylistsResult = await _moderatorService.GetAllPlaylistPendingSubmissionsAsync(page, pageSize, username);

                return Ok(pendingPlaylistsResult);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return BadRequest(new { ex.Message });
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

        [Authorize(Roles = "Owner, Senior Admin, Admin")]
        [HttpPost("moderator/playlists/{playlistId:guid}/submission")]
        public async Task<IActionResult> ReviewPlaylistSubmission([FromRoute] Guid playlistId, [FromBody] ModeratorSubmissionReviewDTO playlistReviewDTO)
        {
            try
            {
                var adminId = User.GetUserIdFromClaims();

                var playlistReviewResponse = await _moderatorService.PlaylistSubmissionReviewAsync(adminId, playlistId, playlistReviewDTO);

                return Ok(playlistReviewResponse);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { ex.Message });
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
    }
}