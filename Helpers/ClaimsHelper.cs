using System.Security.Claims;

namespace foodtopia.Helpers
{
    public static class ClaimsHelper
    {
        public static Guid GetUserIdFromClaims(this ClaimsPrincipal user)
        {
            var userIdStr = user.FindFirstValue("user_id");
            // parse from type string to Guid (AppUser's id type set inside Model)
            if (!Guid.TryParse(userIdStr, out Guid userId)) throw new UnauthorizedAccessException("Invalid id within JWT");

            return userId;
        }
        public static bool IsGuest(this ClaimsPrincipal user)
        {
            // '!' null-forgiving operator because AppUser Model "IsGuest" is auto assigned to "false" regardless.
            return bool.Parse(user.FindFirstValue("is_guest")!);
        }
    }
}