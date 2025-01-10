using foodtopia.Models;

namespace foodtopia.Database.Seeds
{
    public static class RecipeSeed
    {
        public static IEnumerable<Recipe> GetRecipes(IEnumerable<Country> countries)
        {

            return new List<Recipe>{
                new Recipe
                {
                    Id = RecipeSeedUUID.LowCaloriePizza,
                    Name = "Low calorie pizza",
                    UserId = null,
                    CountryId = CountrySeedUUID.USA,
                    // CountryId = countries.FirstOrDefault(c => c.Name == "USA")?.Id,
                    ImageUrl = "images/recipes/low_calorie_pizza.jpg",
                    Ingredients = new List<Ingredient>(), // initialize as empty (since Recipe model has as "required") then shortly after seeded
                    Instructions = new List<Instruction>() // initialize as empty (since Recipe model has as "required") then shortly after seeded
                }
            };
        }
    }
}