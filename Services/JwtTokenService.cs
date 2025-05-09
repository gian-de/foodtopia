using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using foodtopia.Interfaces;
using foodtopia.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace foodtopia.Services
{
    public class JwtTokenService : IJwtTokenService
    {
        private readonly IConfiguration _config;
        private readonly UserManager<AppUser> _userManager;
        private readonly SymmetricSecurityKey _key;
        public JwtTokenService(IConfiguration config, UserManager<AppUser> userManager)
        {
            _config = config;
            _userManager = userManager;

            var signingKey = Environment.GetEnvironmentVariable("JWT_SIGNING_KEY");
            if (string.IsNullOrEmpty(signingKey)) throw new InvalidOperationException("JWT_SIGNING_KEY environment variable is not set.");

            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signingKey));
        }
        public async Task<string> CreateTokenAsync(AppUser user)
        {
            // userManager check RETURNS EMPTY LIST (=/= null type) of roles if user doesn't exists (ex. not created yet) OR User's role has been removed and is now an empty list (ex. Admin demoted of perms)
            var roles = await _userManager.GetRolesAsync(user);

            if (string.IsNullOrEmpty(user.UserName)) throw new ArgumentNullException("Cannot issue token: user has no UserName.");
            if (string.IsNullOrEmpty(user.Email)) throw new ArgumentNullException("Cannot issue token: user has no Email.");

            var claims = new List<Claim>{
                new Claim("user_id", user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.GivenName, user.UserName),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("is_guest", user.IsGuest.ToString()),
            };
            // attach claim prop "Role" to "User" by default when generating JWT if User's role not found
            if (!roles.Any())
            {
                claims.Add(new Claim(ClaimTypes.Role, "User"));
            }
            else
            {
                foreach (var role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }
            }

            var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(3),
                SigningCredentials = creds,
                Issuer = _config["JWT:Issuer"],
                Audience = _config["JWT:Audience"]
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}