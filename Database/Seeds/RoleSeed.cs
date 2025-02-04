using Microsoft.AspNetCore.Identity;

namespace foodtopia.Database.Seeds
{
    public static class RoleSeed
    {
        public static List<IdentityRole<Guid>> GetRoles()
        {
            return new List<IdentityRole<Guid>>
            {
                new IdentityRole<Guid>
                {
                    Id = RoleSeedUUID.Admin,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole<Guid>
                {
                    Id = RoleSeedUUID.User,
                    Name = "User",
                    NormalizedName = "USER"
                }
            };
        }
    }
}