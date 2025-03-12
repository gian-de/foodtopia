using foodtopia.DTOs.Admin;
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
        [Authorize(Roles = "Senior Admin")]
        [HttpGet("senior-admin/admins")]
        public async Task<IActionResult> GetAllAdmins()
        {
            try
            {
                var admins = await _seniorAdminService.GetAllAdminsAsync();
                return Ok(admins);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [Authorize(Roles = "Senior Admin")]
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
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [Authorize(Roles = "Senior Admin")]
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
    }
}