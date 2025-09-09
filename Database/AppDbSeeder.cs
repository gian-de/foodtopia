using foodtopia.Models;
using Microsoft.AspNetCore.Identity;

namespace foodtopia.Database;

public static class AppDbSeeder
{
    public static async Task SeedAsync(
                                UserManager<AppUser> userManager,
                                RoleManager<IdentityRole<Guid>> roleManager)
    {
        var ownerUserGuid = Guid.Parse("f0d0acba-6cad-4081-a14b-9973f4444962");
        var deletedUserGuid = Guid.Parse("00000000-0000-0000-0000-000000000001");


        if (await userManager.FindByIdAsync(ownerUserGuid.ToString()) is null)
        {
            var ownerUserPassword = Environment.GetEnvironmentVariable("SEED_OWNER_PASSWORD")
                                ?? throw new Exception("Missing SEED_OWNER_PASSWORD variable in .env file.");

            var ownerUser = new AppUser
            {
                Id = ownerUserGuid,
                UserName = "Owner",
                NormalizedUserName = "OWNER",
                Email = "owner@foodtopia.com",
                EmailConfirmed = true,
            };

            await userManager.CreateAsync(ownerUser, ownerUserPassword);
            if (await roleManager.RoleExistsAsync("Owner"))
            {

                await userManager.AddToRoleAsync(ownerUser, "Owner");
            }
            else
            {
                throw new InvalidOperationException("Owner role doesn't exist, double check seeding logic/flow");
            }
        }

        if (await userManager.FindByIdAsync(deletedUserGuid.ToString()) is null)
        {

            var deletedUserPassword = Environment.GetEnvironmentVariable("SEED_DELETEDUSER_PASSWORD")
                                    ?? throw new Exception("Missing SEED_DELETEDUSER_PASSWORD variable in .env file.");
            var deletedUser = new AppUser
            {
                Id = deletedUserGuid,
                UserName = "deleted-user",
                Email = "deleted@foodtopia.com",
                EmailConfirmed = true,
            };

            await userManager.CreateAsync(deletedUser, deletedUserPassword);
        }
    }
}