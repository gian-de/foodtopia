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
                    Id = Guid.NewGuid(),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Name = "Flour",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.NewGuid(),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Name = "Egg",
                    Quantity = 2,
                    Measurement = ""
                },
                new Ingredient
                {
                    Id = Guid.NewGuid(),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Name = "Sauce",
                    Quantity = 1,
                    Measurement = "cup"
                },
            };
        }
    }
}