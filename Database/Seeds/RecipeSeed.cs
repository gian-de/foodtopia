using foodtopia.Models;

namespace foodtopia.Database.Seeds
{
    public static class RecipeSeed
    {
        public static IEnumerable<Recipe> GetRecipes()
        {

            return new List<Recipe>{
                new Recipe
                {
                    Id = RecipeSeedUUID.LowCaloriePizza,
                    Name = "Low calorie pizza",
                    UserId = AppUserSeedUUID.PeterParker,
                    CountryId = CountrySeedUUID.USA,
                    ImageUrl = "images/recipes/low_calorie_pizza.jpg",
                    Ingredients = new List<Ingredient>(), // initialize as empty (since Recipe model has as "required") then shortly after seeded List
                    Instructions = new List<Instruction>(), // initialize as empty (since Recipe model has as "required") then shortly after seeded List
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.ClassicCheeseburger,
                    Name = "Classic Cheeseburger",
                    UserId = AppUserSeedUUID.PeterParker,
                    CountryId = CountrySeedUUID.USA,
                    ImageUrl = "images/recipes/classic_cheeseburger.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.TacosAlPastor,
                    Name = "Tacos al Pastor",
                    UserId = AppUserSeedUUID.PeterParker,
                    CountryId = CountrySeedUUID.Mexico,
                    ImageUrl = "images/recipes/tacos_al_pastor.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.ChickenBiryani,
                    Name = "Chicken Biryani",
                    UserId = AppUserSeedUUID.PeterParker,
                    CountryId = CountrySeedUUID.India,
                    ImageUrl = "images/recipes/chicken_biryani.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.PekingDuck,
                    Name = "Peking Duck",
                    UserId = AppUserSeedUUID.AdamWarlock,
                    CountryId = CountrySeedUUID.China,
                    ImageUrl = "images/recipes/peking_duck.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.BeefStroganoff,
                    Name = "Beef Stroganoff",
                    UserId = AppUserSeedUUID.AdamWarlock,
                    CountryId = CountrySeedUUID.Russia,
                    ImageUrl = "images/recipes/beef_stroganoff.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Feijoada,
                    Name = "Feijoada",
                    UserId = AppUserSeedUUID.RocketRaccoon,
                    CountryId = CountrySeedUUID.Brazil,
                    ImageUrl = "images/recipes/feijoada.png",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>()
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Sushi,
                    Name = "Sushi",
                    UserId = AppUserSeedUUID.DrStrange,
                    CountryId = CountrySeedUUID.Japan,
                    ImageUrl = "images/recipes/sushi.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.PadThai,
                    Name = "Pad Thai",
                    UserId = AppUserSeedUUID.Ironfist,
                    CountryId = CountrySeedUUID.Thailand,
                    ImageUrl = "images/recipes/pad_thai.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Pho,
                    Name = "Pho",
                    UserId = AppUserSeedUUID.Ironfist,
                    CountryId = CountrySeedUUID.Vietnam,
                    ImageUrl = "images/recipes/pho.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Ceviche,
                    Name = "Ceviche",
                    UserId = AppUserSeedUUID.Ironfist,
                    CountryId = CountrySeedUUID.Peru,
                    ImageUrl = "images/recipes/ceviche.jpeg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Kebab,
                    Name = "Kebab",
                    UserId = null,
                    CountryId = CountrySeedUUID.Turkey,
                    ImageUrl = "images/recipes/kebab.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.ButterChicken,
                    Name = "Butter Chicken",
                    UserId = null,
                    CountryId = CountrySeedUUID.Pakistan,
                    ImageUrl = "images/recipes/butter_chicken.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Bobotie,
                    Name = "Bobotie",
                    UserId = null,
                    CountryId = CountrySeedUUID.SouthAfrica,
                    ImageUrl = "images/recipes/bobotie.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Kimchi,
                    Name = "Kimchi",
                    UserId = null,
                    CountryId = CountrySeedUUID.SouthKorea,
                    ImageUrl = "images/recipes/kimchi.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Pierogi,
                    Name = "Pierogi",
                    UserId = null,
                    CountryId = CountrySeedUUID.Poland,
                    ImageUrl = "images/recipes/pierogi.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.FishAndChips,
                    Name = "Fish and Chips",
                    UserId = null,
                    CountryId = CountrySeedUUID.UK,
                    ImageUrl = "images/recipes/fish_and_chips.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Moussaka,
                    Name = "Moussaka",
                    UserId = null,
                    CountryId = CountrySeedUUID.Greece,
                    ImageUrl = "images/recipes/moussaka.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Lasagna,
                    Name = "Lasagna",
                    UserId = null,
                    CountryId = CountrySeedUUID.Italy,
                    ImageUrl = "images/recipes/lasagna.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Croissant,
                    Name = "Croissant",
                    UserId = null,
                    CountryId = CountrySeedUUID.France,
                    ImageUrl = "images/recipes/croissant.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                },
                new Recipe
                {
                    Id = RecipeSeedUUID.Shawarma,
                    Name = "Shawarma",
                    UserId = null,
                    CountryId = CountrySeedUUID.Egypt,
                    ImageUrl = "images/recipes/shawarma.jpg",
                    Ingredients = new List<Ingredient>(),
                    Instructions = new List<Instruction>(),
                    VisibilityStatus = "public"
                }
            };
        }
    }
}