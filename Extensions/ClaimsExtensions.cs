using System.Security.Claims;

namespace foodtopia.Extensions
{
    public static class ClaimsExtensions
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            // return user.Claims.SingleOrDefault(c => c.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname")).Value;
            // return user.Claims.SingleOrDefault(c => c.Type == ClaimTypes.GivenName).Value;

            var claim = user.FindFirst(ClaimTypes.GivenName);
            if (claim is null) throw new InvalidOperationException("Username claim is missing from the token.");
            return claim.Value;
        }
    }
}