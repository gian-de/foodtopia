using Microsoft.AspNetCore.Identity;

namespace foodtopia.Database.Seeds
{
    public static class RoleSeed
    {
        public static IEnumerable<IdentityRole> GetRoles()
        {
            return new List<IdentityRole>{
                new IdentityRole
                {
                    Id = RoleSeedUUID.Admin.ToString(),
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = RoleSeedUUID.User.ToString(),
                    Name = "User",
                    NormalizedName = "USER"
                }
            };
        }
    }
}