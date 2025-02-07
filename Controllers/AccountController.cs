using System.Text;
using foodtopia.DTOs;
using foodtopia.DTOs.Account;
using foodtopia.Interfaces;
using foodtopia.Models;
using foodtopia.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;

namespace foodtopia.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        string baseURL = "http://localhost:5001";

        private readonly UserManager<AppUser> _userManager;
        private readonly IJwtTokenService _jwtTokenService;
        private readonly IEmailService _emailService;
        public AccountController(UserManager<AppUser> userManager, IJwtTokenService jwtTokenService, IEmailService emailService)
        {
            _userManager = userManager;
            _jwtTokenService = jwtTokenService;
            _emailService = emailService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO registerDTO)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);

                var appUser = new AppUser
                {
                    UserName = registerDTO.Username,
                    Email = registerDTO.Email,
                };

                var createdUser = await _userManager.CreateAsync(appUser, registerDTO.Password);
                if (!createdUser.Succeeded) return BadRequest(createdUser.Errors);

                // Email Confirmation workflow
                var emailToken = await _userManager.GenerateEmailConfirmationTokenAsync(appUser);
                var code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(emailToken));
                var confirmationLink = $"{baseURL}/api/account/confirm-email?email={appUser.Email}&code={code}";

                var roleResult = await _userManager.AddToRoleAsync(appUser, "User");
                if (!roleResult.Succeeded) return StatusCode(500, new { Message = "Error when trying to add user to role", roleResult.Errors });

                await _emailService.SendEmailConfirmationAsync(appUser.Email, confirmationLink);

                return Ok(new NewUserDTO
                {
                    UserName = appUser.UserName,
                    Email = appUser.Email,
                    JwtToken = _jwtTokenService.CreateToken(appUser)
                }
                    );
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [HttpGet("confirm-email")]
        public async Task<IActionResult> ConfirmEmail([FromQuery] string email, [FromQuery] string code)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user is null) return NotFound("User not found");

            var emailToken = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));

            var result = await _userManager.ConfirmEmailAsync(user, emailToken);

            return result.Succeeded ? Ok("Email confirmed") : BadRequest(result.Errors);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
        {
            var incorrectLoginCredentialMessage = "Username or password incorrect.";

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var user = await _userManager.FindByNameAsync(loginDTO.Username);
            if (user is null) return Unauthorized(incorrectLoginCredentialMessage);

            var validPassword = await _userManager.CheckPasswordAsync(user, loginDTO.Password);
            if (!validPassword) return Unauthorized(incorrectLoginCredentialMessage);

            var confirmedEmail = await _userManager.IsEmailConfirmedAsync(user);
            if (!confirmedEmail) return BadRequest("Please confirm your email address to be able to login.");

            return Ok(
                new NewUserDTO
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    JwtToken = _jwtTokenService.CreateToken(user)
                }
            );
        }
    }
}