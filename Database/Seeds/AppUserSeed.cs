using foodtopia.Models;
using Microsoft.AspNetCore.Identity;

namespace foodtopia.Database.Seeds
{
    public static class AppUserSeed
    {
        public static List<AppUser> GetAppUsers()
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return new List<AppUser>()
            {
                new AppUser
                {
                    Id = AppUserSeedUUID.PeterParker,
                    UserName = "Spider-man",
                    NormalizedUserName="SPIDER-MAN",
                    Email = "spiderman@email.com",
                    NormalizedEmail = "SPIDERMAN@EMAIL.COM",
                    PasswordHash = passwordHasher.HashPassword(null, "Spiderman1!")
                },
                new AppUser
                {
                    Id = AppUserSeedUUID.AdamWarlock,
                    UserName = "Warlock",
                    NormalizedUserName = "WARLOCK",
                    Email = "adamwarlock@email.com",
                    NormalizedEmail = "ADAMWARLOCK@EMAIL.COM",
                    PasswordHash = passwordHasher.HashPassword(null, "AdamWarlock1!")
                },
                new AppUser
                {
                    Id = AppUserSeedUUID.RocketRaccoon,
                    UserName = "Rocket",
                    NormalizedUserName = "ROCKET",
                    Email = "rocketraccoon@email.com",
                    NormalizedEmail = "ROCKETRACCOON@EMAIL.COM",
                    PasswordHash = passwordHasher.HashPassword(null, "RocketRaccoon!")
                },
                new AppUser
                {
                    Id = AppUserSeedUUID.DrStrange,
                    UserName = "DrStrange",
                    NormalizedUserName = "DRSTRANGE",
                    Email = "drstrange@email.com",
                    NormalizedEmail = "DRSTRANGE@EMAIL.COM",
                    PasswordHash = passwordHasher.HashPassword(null,"DrStrange1!")
                },
                new AppUser
                {
                    Id = AppUserSeedUUID.Ironfist,
                    UserName = "IronFist",
                    NormalizedUserName = "IRONFIST",
                    Email = "ironfist@email.com",
                    NormalizedEmail = "IRONFIST@EMAIL.COM",
                    PasswordHash = passwordHasher.HashPassword(null,"IronFist1!")
                }
            };
        }
    }
}