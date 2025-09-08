using System.Net;
using System.Security.Claims;
using System.Text;
using foodtopia.DTOs;
using foodtopia.DTOs.Account;
using foodtopia.Interfaces;
using foodtopia.Models;
using foodtopia.Services;
using Microsoft.AspNetCore.Authorization;
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
        readonly string baseUrl = Environment.GetEnvironmentVariable("BASE_URL") ?? "http://localhost:5001";
        readonly string frontendUrl = Environment.GetEnvironmentVariable("FRONTEND_URL") ?? "http://localhost:3000";

        // readonly string baseUrl = "http://localhost:5001";
        // readonly string frontendUrl = "http://localhost:3000";

        private readonly UserManager<AppUser> _userManager;
        private readonly AccountService _accountService;
        private readonly IJwtTokenService _jwtTokenService;
        private readonly IEmailService _emailService;
        public AccountController(UserManager<AppUser> userManager, AccountService accountService, IJwtTokenService jwtTokenService, IEmailService emailService)
        {
            _userManager = userManager;
            _accountService = accountService;
            _jwtTokenService = jwtTokenService;
            _emailService = emailService;
        }

        private async Task<string> GenerateConfirmationLinkAsync(AppUser user)
        {
            var emailToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var tokenEncoded = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(emailToken));
            var emailEncoded = WebUtility.UrlEncode(user.Email);
            return $"{baseUrl}/api/account/confirm-email?email={emailEncoded}&token={tokenEncoded}";
        }

        [HttpPost("register")]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO registerDTO)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);

                var emailExists = await _userManager.FindByEmailAsync(registerDTO.Email!);
                if (emailExists is not null) return BadRequest(new { Message = "An account with this email already exists." });

                var appUser = new AppUser
                {
                    // null forgive both fields since there's validation in RegisterDTO
                    UserName = registerDTO.Username!.ToLowerInvariant(),
                    Email = registerDTO.Email!.ToLowerInvariant(),
                };

                var createdUser = await _userManager.CreateAsync(appUser, registerDTO.Password!); // null forgive registerDTO.Password since there's validation in RegisterDTO
                if (!createdUser.Succeeded) return BadRequest(createdUser.Errors);

                // // Email Confirmation workflow
                // var emailToken = await _userManager.GenerateEmailConfirmationTokenAsync(appUser);
                // var tokenEncoded = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(emailToken));
                // var emailEncoded = WebUtility.UrlEncode(appUser.Email);
                // var confirmationLink = $"{baseURL}/api/account/confirm-email?email={emailEncoded}&token={tokenEncoded}";

                var confirmationLink = await GenerateConfirmationLinkAsync(appUser);

                var roleResult = await _userManager.AddToRoleAsync(appUser, "User");
                if (!roleResult.Succeeded) return StatusCode(500, new { Message = "Error when trying to add user to role", roleResult.Errors });

                await _emailService.SendEmailConfirmationAsync(appUser.Email, confirmationLink);

                return Ok(new NewUserDTO
                {
                    // null forgive both username and email since there's validation above
                    UserName = appUser.UserName!,
                    Email = appUser.Email,
                    JwtToken = await _jwtTokenService.CreateTokenAsync(appUser),
                    Role = "User"
                });
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

        [HttpGet("confirm-email")]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> ConfirmEmail([FromQuery] string email, [FromQuery] string token)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(token))
            {
                return Redirect($"{frontendUrl}/email-confirmation?status=error&message=Invalid confirmation link.");
            }

            try
            {
                // decode email sent as encoded
                var decodedEmail = WebUtility.UrlDecode(email);
                var decodedToken = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(token));

                var user = await _userManager.FindByEmailAsync(decodedEmail);
                if (user is null) return Redirect($"{frontendUrl}/email-confirmation?status=error&message=User not found.");

                var result = await _userManager.ConfirmEmailAsync(user, decodedToken);

                if (result.Succeeded)
                {
                    var jwtToken = await _jwtTokenService.CreateTokenAsync(user);
                    var encodedToken = Uri.EscapeDataString(jwtToken);
                    var encodedUsername = Uri.EscapeDataString(user?.UserName ?? "");
                    var encodedEmail = Uri.EscapeDataString(user?.Email ?? "");

                    return Redirect($"{frontendUrl}/email-confirmation?status=success&message=Email confirmed!&token={encodedToken}&username={encodedUsername}&email={encodedEmail}");
                }
                else
                {
                    return Redirect($"{frontendUrl}/email-confirmation?status=error&message=Error occurred, please try again another time.");
                }
            }
            catch (Exception ex)
            {
                return Redirect($"{frontendUrl}/email-confirmation?status=error&message=Invalid or expired confirmation link.");
            }
        }

        [HttpPost("resend-email-confirmation")]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> ResendEmailConfirmation([FromBody] ResendEmailConfirmationDTO resendEmailDTO)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);

                var user = await _userManager.FindByEmailAsync(resendEmailDTO.Email);

                if (user is not null)
                {
                    var confirmationLink = await GenerateConfirmationLinkAsync(user);

                    await _emailService.SendEmailConfirmationAsync(user.Email!, confirmationLink);
                }

                return Ok(new { message = "A confirmation email has been sent just now." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Failed to resend email confirmation link, please try again at another time." });
            }
        }

        [HttpPost("login")]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
        {
            try
            {
                var incorrectLoginCredentialMessage = "Username or password incorrect.";

                if (!ModelState.IsValid) return BadRequest(ModelState);

                var user = await _userManager.FindByNameAsync(loginDTO.Username.ToLowerInvariant());
                if (user is null) return Unauthorized(incorrectLoginCredentialMessage);

                var validPassword = await _userManager.CheckPasswordAsync(user, loginDTO.Password);
                if (!validPassword) return Unauthorized(incorrectLoginCredentialMessage);

                var confirmedEmail = await _userManager.IsEmailConfirmedAsync(user);
                if (!confirmedEmail) return BadRequest("Please confirm your email address to be able to login.");

                return Ok(
                    new NewUserDTO
                    {
                        // null forgive both username and email since there's validation above 
                        UserName = user.UserName!,
                        Email = user.Email!,
                        JwtToken = await _jwtTokenService.CreateTokenAsync(user),
                        Role = (await _userManager.GetRolesAsync(user)).FirstOrDefault() ?? "User"
                    }
                );
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

        [HttpPost("guest-login")]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> LoginAsGuest()
        {
            try
            {
                var guestUsername = $"Guest-{Guid.NewGuid().ToString().Substring(0, 11)}";

                var guestUser = new AppUser
                {
                    UserName = guestUsername,
                    Email = $"{guestUsername}@guest.com",
                    IsGuest = true,
                };

                var result = await _userManager.CreateAsync(guestUser);
                if (!result.Succeeded) return StatusCode(500, "Couldn't create guest account unfortunately.");

                return Ok(
                    new NewUserDTO
                    {
                        UserName = guestUsername,
                        Email = guestUser.Email,
                        JwtToken = await _jwtTokenService.CreateTokenAsync(guestUser),
                        Role = "Guest"
                    }
                );
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

        [HttpPost("forgot-username")]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> ForgotUsername([FromBody] ForgotUsernameRequestDTO requestDTO)
        {
            try
            {

                if (!ModelState.IsValid) return BadRequest(ModelState);

                var user = await _userManager.FindByEmailAsync(requestDTO.Email);

                // for security reason, never return NotFound (it would reveal if the email is truthy for a bad actor)
                if (user is not null) await _emailService.SendEmailUsernameInfoAsync(user.Email!, user.UserName!); // '!' to suppress warning, .Email and .Username should exists since this code will only run if the 'user' is truthy

                return Ok(new { Message = "If an account with this email exists, the Username login info has been sent." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while processing your request." });
            }
        }

        [HttpPost("forgot-password")]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordRequestDTO requestDTO)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var user = await _userManager.FindByEmailAsync(requestDTO.Email);
            if (user is null) return BadRequest("Invalid payload.");

            var resetPasswordToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            if (string.IsNullOrEmpty(resetPasswordToken)) return BadRequest("Something went wrong when creating the reset token.");

            var tokenEncoded = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(resetPasswordToken));
            var emailEncoded = WebUtility.UrlEncode(user.Email);

            var passwordResetLink = $"{frontendUrl}/api/account/reset-password?token={tokenEncoded}&email={emailEncoded}";

            // null forgive 'user.email' since there's validation above line 154
            await _emailService.SendEmailPasswordResetAsync(user.Email!, passwordResetLink);

            return Ok(new { Message = "Email to reset your password has been sent." });
        }

        [HttpPost("reset-password")]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequestDTO requestDTO)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            // decode both email and token since they're sent over encoded
            var decodedEmail = WebUtility.UrlDecode(requestDTO.Email);
            var decodedToken = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(requestDTO.Token));

            var user = await _userManager.FindByEmailAsync(decodedEmail);
            if (user is null) return BadRequest("Invalid payload.");


            var result = await _userManager.ResetPasswordAsync(user, decodedToken, requestDTO.Password);
            if (!result.Succeeded) return BadRequest("Something went wrong.");

            return Ok("Password has been reset successfully.");
        }

        [HttpDelete("delete-account")]
        [Authorize]
        public async Task<IActionResult> DeleteAccount()
        {
            try
            {
                var userIdStr = User.FindFirstValue("user_id");
                if (!Guid.TryParse(userIdStr, out Guid userId)) return Unauthorized("Invalid user_id inside JWT.");

                await _accountService.DeleteAccountAsync(userId);
                return Ok(new { Message = "Account deleted successfully." });
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