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
        [Authorize(Roles = "Senior Admin")]
        [HttpPost("senior-admin/add-admin")]
        public async Task<IActionResult> AddAdminRole([FromBody] AddAdminRoleDTO dto)
        {
            var result = await _seniorAdminService.AddAdminRoleAsync(dto.userId);
            return Ok(result);
        }
    }
}