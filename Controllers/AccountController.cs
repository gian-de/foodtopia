using System.Net;
using System.Text;
using foodtopia.DTOs;
using foodtopia.DTOs.Account;
using foodtopia.Interfaces;
using foodtopia.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.AspNetCore.WebUtilities;

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
        [EnableRateLimiting("fixed-limiter-strict")]
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
                var tokenEncoded = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(emailToken));
                var emailEncoded = WebUtility.UrlEncode(appUser.Email);
                var confirmationLink = $"{baseURL}/api/account/confirm-email?email={emailEncoded}&token={tokenEncoded}";

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
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> ConfirmEmail([FromQuery] string email, [FromQuery] string token)
        {
            // decode email sent as encoded
            var decodedEmail = WebUtility.UrlDecode(email);
            var user = await _userManager.FindByEmailAsync(decodedEmail);
            if (user is null) return NotFound("User not found");

            var emailToken = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(token));

            var result = await _userManager.ConfirmEmailAsync(user, emailToken);

            return result.Succeeded ? Ok("Email confirmed") : BadRequest(result.Errors);
        }

        [HttpPost("login")]
        [EnableRateLimiting("fixed-limiter-strict")]
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

        [HttpPost("forgot-password")]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordRequestDTO requestDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var user = await _userManager.FindByEmailAsync(requestDto.Email);
            if (user is null) return BadRequest("Invalid payload.");

            var resetPasswordToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            if (string.IsNullOrEmpty(resetPasswordToken)) return BadRequest("Something went wrong when creating the reset token.");

            var tokenEncoded = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(resetPasswordToken));
            var emailEncoded = WebUtility.UrlEncode(user.Email);

            var passwordResetLink = $"{baseURL}/api/account/reset-password?token={tokenEncoded}&email={emailEncoded}";

            await _emailService.SendEmailPasswordResetAsync(user.Email, passwordResetLink);

            return Ok(new { Message = "Email to reset your password has been sent." });
        }

        [HttpPost("reset-password")]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequestDTO requestDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            // decode both email and token since they're sent over encoded
            var decodedEmail = WebUtility.UrlDecode(requestDto.Email);
            var decodedToken = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(requestDto.Token));

            var user = await _userManager.FindByEmailAsync(decodedEmail);
            if (user is null) return BadRequest("Invalid payload.");

            var result = await _userManager.ResetPasswordAsync(user, decodedToken, requestDto.Password);
            if (!result.Succeeded) return BadRequest("Something went wrong12.");

            return Ok("Password has been reset successfully.");
        }
    }
}