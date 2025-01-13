using foodtopia.Models;

namespace foodtopia.Database.Seeds
{
    public static class IngredientSeed
    {
        public static IEnumerable<Ingredient> GetIngredients()
        {
            return new List<Ingredient>
            {
                new Ingredient
                {
                    Id = Guid.Parse("697e9870-e247-411e-96f3-e56b8d21be1b"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Name = "Flour",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("be8b28cc-b3ba-4d35-866e-5d4ce096a788"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Name = "Egg",
                    Quantity = 2,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.Parse("f639974d-9bf6-4efd-954c-5abec793ac11"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Name = "Sauce",
                    Quantity = 1,
                    Measurement = "cup"
                },
            };
        }
    }
}