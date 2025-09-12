using foodtopia.DTOs.Owner;
using foodtopia.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace foodtopia.Controllers
{
    [Authorize(Roles = "Owner")]
    [Route("api/owner")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _ownerService;

        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        [HttpGet("owners")]
        public async Task<IActionResult> GetAllOwners([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            try
            {
                var ownersResult = await _ownerService.GetAllOwnersAsync(page, pageSize);
                return Ok(ownersResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [HttpPost("promote-to-owner")]
        public async Task<IActionResult> AddOwnerRole([FromBody] PromoteToOwnerRoleDTO dto)
        {
            try
            {
                var promoteToOwnerResult = await _ownerService.PromoteToOwnerRoleAsync(dto.userId);

                return Ok(promoteToOwnerResult);
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

        [HttpPost("promote-to-senior-admin")]
        public async Task<IActionResult> AddSeniorAdminRole([FromBody] PromoteToSeniorAdminRoleDTO dto)
        {
            try
            {
                var promoteToSeniorAdminResult = await _ownerService.PromoteToSeniorAdminRoleAsync(dto.userId);

                return Ok(promoteToSeniorAdminResult);
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

        [HttpDelete("demote-to-senior-admin/{userId:guid}")]
        public async Task<IActionResult> DemoteOwnerToSeniorAdminRole([FromRoute] Guid userId)
        {
            try
            {
                var demoteToSeniorAdminResult = await _ownerService.DemoteToSeniorAdminRoleAsync(userId);

                return Ok(demoteToSeniorAdminResult);
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

        [HttpDelete("demote-to-admin/{userId:guid}")]
        public async Task<IActionResult> DemoteSeniorAdminToAdminRole([FromRoute] Guid userId)
        {
            try
            {
                var demoteToAdminResult = await _ownerService.DemoteToAdminRoleAsync(userId);

                return Ok(demoteToAdminResult);
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
    }
}