using foodtopia.Models;

namespace foodtopia.Database.Seeds
{
    public static class HeartedRecipeSeed
    {
        public static List<HeartedRecipe> GetAll()
        {
            return new List<HeartedRecipe>
            {
                new HeartedRecipe
                {
                    Id = Guid.Parse("8c051925-1bdc-4643-b5bf-d682fa1f4c27"),
                    UserId = AppUserSeedUUID.PeterParker,
                    RecipeId = RecipeSeedUUID.Kebab
                },
                new HeartedRecipe
                {
                    Id = Guid.Parse("e5ab974d-adca-46af-9173-c67a1dd0e8d5"),
                    UserId = AppUserSeedUUID.PeterParker,
                    RecipeId = RecipeSeedUUID.BeefStroganoff
                },
                new HeartedRecipe
                {
                    Id = Guid.Parse("27e6491c-0ca0-44e7-99e1-4badd4df766e"),
                    UserId = AppUserSeedUUID.PeterParker,
                    RecipeId = RecipeSeedUUID.Bobotie
                },
                new HeartedRecipe
                {
                    Id = Guid.Parse("4bd052d1-088b-463c-8281-b386bbbc056f"),
                    UserId = AppUserSeedUUID.PeterParker,
                    RecipeId = RecipeSeedUUID.ButterChicken
                },
                new HeartedRecipe
                {
                    Id = Guid.Parse("e16d74fa-df41-4877-b3be-fc980fbe40df"),
                    UserId = AppUserSeedUUID.PeterParker,
                    RecipeId = RecipeSeedUUID.Pho
                },
                new HeartedRecipe
                {
                    Id = Guid.Parse("5f14d4ea-69fd-4b99-8aca-d06659f1eed5"),
                    UserId = AppUserSeedUUID.PeterParker,
                    RecipeId = RecipeSeedUUID.PadThai
                },
                new HeartedRecipe
                {
                    Id = Guid.Parse("5b97e40b-5155-41e5-923f-b9214cf840f8"),
                    UserId = AppUserSeedUUID.AdamWarlock,
                    RecipeId = RecipeSeedUUID.PadThai
                },
                new HeartedRecipe
                {
                    Id = Guid.Parse("4baa4456-d138-4181-a556-0c34ac9d399d"),
                    UserId = AppUserSeedUUID.AdamWarlock,
                    RecipeId = RecipeSeedUUID.LowCaloriePizza
                },
                new HeartedRecipe
                {
                    Id = Guid.Parse("b5ae64ba-a904-4dee-8759-dc0722144058"),
                    UserId = AppUserSeedUUID.RocketRaccoon,
                    RecipeId = RecipeSeedUUID.LowCaloriePizza
                },
                new HeartedRecipe
                {
                    Id = Guid.Parse("61939421-e5cf-4700-82f1-8d103387170f"),
                    UserId = AppUserSeedUUID.DrStrange,
                    RecipeId = RecipeSeedUUID.LowCaloriePizza
                },
                new HeartedRecipe
                {
                    Id = Guid.Parse("d069c969-1acd-4f5c-a942-77a2b05499f5"),
                    UserId = AppUserSeedUUID.Ironfist,
                    RecipeId = RecipeSeedUUID.LowCaloriePizza
                },
            };
        }
    }
}