using foodtopia.Models;

namespace foodtopia.Database.Seeds
{
    public static class IngredientSeed
    {
        public static IEnumerable<Ingredient> GetIngredients()
        {
            return new List<Ingredient>
            {
                // start Low Cal Pizza
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
                // end Low Cal Pizza

                // start Classic Cheeseburger
                new Ingredient
                {
                    Id = Guid.Parse("ffde08e9-ce76-4a6d-88c2-437205c0ad97"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Name = "Ground beef",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("61046199-47f5-4d3b-8834-1cb7b8464a82"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Name = "Burger buns",
                    Quantity = 4,
                    Measurement = "pcs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("045ff37e-63c4-413b-9553-b6082ef70c3d"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Name = "Cheddar cheese",
                    Quantity = 4,
                    Measurement = "slices"
                },
                new Ingredient
                {
                    Id = Guid.Parse("830d8300-a1d6-408a-8ab3-99541fb423e3"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Name = "Lettuce leaves",
                    Quantity = 4,
                    Measurement = "pcs"
                },
                // end Classic Cheeseburger

                // start Tacos al Pastor
                new Ingredient
                {
                    Id = Guid.Parse("0bce1bf7-1cea-43de-9cee-d85e1eeeb89f"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Name = "Pork shoulder",
                    Quantity = 2,
                    Measurement = "lbs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6f48049f-e9bb-489c-b98a-f57c3c0212ed"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Name = "Pineapple chunks",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("87f6815c-5992-4f7d-8a49-3f5183e556de"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Name = "Corn tortillas",
                    Quantity = 8,
                    Measurement = "pcs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("a824a011-d517-43e2-8b80-9242324a0242"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Name = "Adobo marinade",
                    Quantity = 1,
                    Measurement = "cup"
                },
                // end Tacos al Pastor

                // start Chicken Biryani 
                new Ingredient
                {
                    Id = Guid.Parse("92fc04e6-7949-44ee-97ef-b795444a8e94"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Name = "Chicken thighs",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("2f743557-4f5f-4783-b3fc-a36a41888940"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Name = "Basmati rice",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("37dec78e-9dac-4a98-99f2-03f0de13facd"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Name = "Yogurt",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("fe728b6c-4c0a-4908-9596-8ed49bdae068"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Name = "Biryani spices",
                    Quantity = 2,
                    Measurement = "tbsp"
                },
                // end Chicken Biryani

                // start Pecking Duck
                new Ingredient
                {
                    Id = Guid.Parse("8a7b5cd3-b432-4c96-8f4e-6d23b9cfe3d7"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Name = "Duck",
                    Quantity = 1,
                    Measurement = "whole"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1e85b82a-0dcd-4c37-a9c9-123e8c3280d5"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Name = "Hoisin sauce",
                    Quantity = 0.5M,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("843d5c82-3a4b-4f8e-b746-389fbf68d1d1"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Name = "Scallions",
                    Quantity = 6,
                    Measurement = "pcs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("a1c8a4d5-22dc-4b8e-a452-573fc9159f65"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Name = "Pancakes",
                    Quantity = 12,
                    Measurement = "pcs"
                },
                // end Pecking Duck
                
                // start Beef Stroganoff
                new Ingredient
                {
                    Id = Guid.Parse("5b9a6f7e-4e3d-8a1f-7b2d-5a6e7f3b8f12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Name = "Beef tenderloin (cut into strips)",
                    Quantity = 1,
                    Measurement = "pound"
                },
                new Ingredient
                {
                    Id = Guid.Parse("8b9c7e6b-3f4d-8a1f-7b2d-6f7a5c8e9f12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Name = "Onion (chopped)",
                    Quantity = 1,
                    Measurement = "medium"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7e5b9c6a-4e3d-8a1f-7b2d-5f7a6b8c9f12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Name = "Mushrooms (sliced)",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6a7b5c9e-3d4a-8f1e-7b2d-9e6b5a7c8f12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Name = "Sour cream",
                    Quantity = 1,
                    Measurement = "cup"
                },
                // end Beef Stroganoff

                // start Feijoada
                new Ingredient
                {
                    Id = Guid.Parse("0df2e923-4f5b-4203-925a-7d2e38c72d1c"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Name = "Black beans",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("1cf5b843-7d93-4f3c-846e-3f9b726ae2d3"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Name = "Smoked sausage",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6b8f35a9-9247-4b5d-8574-2f8b39e7c4b3"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Name = "Pork ribs",
                    Quantity = 1.5M,
                    Measurement = "lbs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("d8b26c49-5f7d-46c4-972b-7a5f8b3d26e5"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Name = "Bay leaves",
                    Quantity = 2,
                    Measurement = "pcs"
                },
                // end Feijoada

                // start Sushi
                new Ingredient
                {
                    Id = Guid.Parse("0fa36b10-e022-42aa-b4c1-73b81ce4e51d"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Name = "Sushi rice",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("8a042d5b-5073-4f71-b823-ab102e3293ea"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Name = "Nori sheets",
                    Quantity = 4,
                    Measurement = "pcs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("b6bef407-688f-4948-8c62-84af05c4c7a6"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Name = "Fresh salmon",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("2b55982b-11e6-4642-afa8-6c727382753f"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Name = "Soy sauce",
                    Quantity = 0.25M,
                    Measurement = "cup"
                },
                // end Sushi

                // start Pad Thai
                new Ingredient
                {
                    Id = Guid.Parse("e1a9d4a8-6d34-41b8-bc70-1245a1e5f5a1"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Name = "Rice noodles",
                    Quantity = 8,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("17dbfc9b-cd68-4937-94b5-d23a36af1c13"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Name = "Shrimp",
                    Quantity = 12,
                    Measurement = "pcs"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6ba75d76-24d6-404e-b437-4b8b44f97c74"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Name = "Bean sprouts",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("913a61c7-5f73-4900-a68b-637d6176f96e"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Name = "Pad Thai sauce",
                    Quantity = 0.5M,
                    Measurement = "cup"
                },
                // end Pad Thai

                // start Pho
                new Ingredient
                {
                    Id = Guid.Parse("a7c5d8f3-4b92-3f6a-96e7-5d2b7c39f4e6"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Name = "Rice noodles",
                    Quantity = 8,
                    Measurement = "oz"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7d4b6f82-5c93-2f8a-9e36-4b7c39e5d3f2"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Name = "Beef broth",
                    Quantity = 4,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("8f5c3a7d-4b92-96e2-7f6b-3a49e2c5f8d7"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Name = "Thinly sliced beef",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9e2b6f7c-3a5d-4b92-83e7-5c39f4a6d8f2"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Name = "Bean sprouts",
                    Quantity = 1,
                    Measurement = "cup"
                },
                // end Pho

                // start Ceviche 
                new Ingredient
                {
                    Id = Guid.Parse("9d6f4b3a-7e8b-5c2f-3a9d-7b6a4e5f8c3f"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Name = "Fresh fish (cubed)",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7b9d6f3e-4a5c-8f2b-7d3a-9c6a4f5e8b7f"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Name = "Lime juice",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4e7a5c3f-9d6b-2f8b-7f3a-8b9c6a5d7f4e"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Name = "Red onion (thinly sliced)",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("5f7c9d4e-3b6a-8f2f-7f5a-9c6b4a7d3e8b"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Name = "Cilantro (chopped)",
                    Quantity = 0.25M,
                    Measurement = "cup"
                },
                // end Ceviche 

                // start Kebab
                new Ingredient
                {
                    Id = Guid.Parse("b02357ad-7e58-448a-a65f-9c5d9e781f22"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Name = "Ground lamb",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6f2c49e4-81f7-4d83-9f89-7a3b2f2a79db"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Name = "Onion (grated)",
                    Quantity = 1,
                    Measurement = "small"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9c4761af-93b6-45f5-b2d5-7a29f4d78163"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Name = "Ground cumin",
                    Quantity = 1,
                    Measurement = "tsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("f8b91c6a-3f2b-4217-b58d-9a38f6e0b277"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Name = "Salt",
                    Quantity = 0.5M,
                    Measurement = "tsp"
                },
                // end Kebab

                // start Butter Chicken
                new Ingredient
                {
                    Id = Guid.Parse("61d3f2a9-7b6e-48d5-8f9c-7a2e9b34d7fa"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Name = "Chicken thighs (cubed)",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("2f97b6d4-5c8a-4a1f-9e7d-3b4f6a91c78e"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Name = "Tomato puree",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("b47e1f6a-8f3c-4a2d-91b7-6a9c58f7e302"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Name = "Heavy cream",
                    Quantity = 0.5M,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7d9e6b2f-3a4c-8f1b-7a5f-6f9b4e0d7a38"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Name = "Butter",
                    Quantity = 2,
                    Measurement = "tbsp"
                },
                // end Butter Chicken

                // start Bobotie
                new Ingredient
                {
                    Id = Guid.Parse("b1c7e5f4-91a8-4b3d-7f2e-6d9a5f8c301b"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Name = "Ground beef",
                    Quantity = 1,
                    Measurement = "lb"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7f6c3a9b-5e1d-4f9a-7b2c-9a8f4e7d6b13"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Name = "Chopped onion",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("4e7b6a3c-9f8d-5b2a-7f1c-6d3e5f9a7b18"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Name = "Milk-soaked bread",
                    Quantity = 2,
                    Measurement = "slices"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9f5d3a7c-1e8b-6a4f-7b9d-3f2e6c9a5f8a"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Name = "Curry powder",
                    Quantity = 2,
                    Measurement = "tbsp"
                },
                // end Bobotie

                // start Kimchi
                new Ingredient
                {
                    Id = Guid.Parse("1f6c5e7a-4b8d-9a3f-7b2c-3f9e7a5d6b12"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Name = "Napa cabbage",
                    Quantity = 1,
                    Measurement = "large head"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6b9a7d4f-3e8c-5a1f-7b2d-9f5c7a4e3b18"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Name = "Korean chili flakes (gochugaru)",
                    Quantity = 3,
                    Measurement = "tbsp"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3f7b6d5a-9c4e-8a1f-7b2d-6a9e5f4c7b12"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Name = "Garlic cloves (minced)",
                    Quantity = 4,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9e3b7a5d-6a4f-1c8b-7f2d-3f6c5f7b9a18"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Name = "Salt",
                    Quantity = 1,
                    Measurement = "tbsp"
                },
                // end Kimchi

                // start Pierogi
                new Ingredient
                {
                    Id = Guid.Parse("4b6e9a3f-7d1c-5f2b-8a7d-3c5e7a9b6f18"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Name = "All-purpose flour",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6a7b9e5c-3f8d-4a1f-7c2d-9f5b7a6e3f12"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Name = "Potatoes (mashed)",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9f5c3e7a-4d1b-6a8f-7b2c-7b9a6e3f5a18"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Name = "Cheddar cheese (shredded)",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3c7b9e6f-5d4a-1a8f-7b2c-9f6a5b7e3f18"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Name = "Egg",
                    Quantity = 1,
                    Measurement = "large"
                },
                // end Pierogi

                // start Fish and Chips
                new Ingredient
                {
                    Id = Guid.Parse("8a7c5f3e-9b6d-4f1a-7b2c-6a9e7b5d3f18"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Name = "Cod fillets",
                    Quantity = 4,
                    Measurement = "pieces"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3f9b7e5a-6d4c-8a1f-7b2d-9f5c7a6e3b12"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Name = "All-purpose flour",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6f3b9a7e-5d4c-1a8f-7b2c-9e6a5f7b3c18"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Name = "Potatoes (cut into fries)",
                    Quantity = 4,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9e5a3f7b-6d4c-8a1f-7b2d-6a9e7f5c3b12"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Name = "Vegetable oil",
                    Quantity = 2,
                    Measurement = "cups"
                },
                // end Fish and Chips

                // start Moussaka
                new Ingredient
                {
                    Id = Guid.Parse("a1d3bbaf-1132-4111-b558-2e027fab8926"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Name = "Eggplants (sliced)",
                    Quantity = 2,
                    Measurement = "large"
                },
                new Ingredient
                {
                    Id = Guid.Parse("b7c9a5e6-3d4f-8a1f-7b2d-6f5e7a9b3c12"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Name = "Ground lamb",
                    Quantity = 1,
                    Measurement = "pound"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9f6b7e5c-3a4d-8a1f-7b2c-5e7a6f9b3c12"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Name = "Tomatoes (diced)",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("5a6e7f9c-3b4d-8a1f-7b2c-9e6a7f5c3b18"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Name = "Béchamel sauce",
                    Quantity = 1,
                    Measurement = "cup"
                },
                // end Moussaka

                // start Lasagna
                new Ingredient
                {
                    Id = Guid.Parse("6f9a5c7b-3e4d-8a1f-7b2d-9b6a5f7c3e12"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Name = "Lasagna noodles",
                    Quantity = 12,
                    Measurement = "pieces"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7b6f9c5e-3d4a-8a1f-7b2d-5e7c9a6f3b18"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Name = "Ground beef",
                    Quantity = 1,
                    Measurement = "pound"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3f7a6b9e-5c4d-8a1f-7b2d-9e6a5f9b7c18"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Name = "Ricotta cheese",
                    Quantity = 2,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9e5b7c6a-3f4d-8a1f-7b2d-5f6e7a9c3b18"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Name = "Mozzarella cheese (shredded)",
                    Quantity = 2,
                    Measurement = "cups"
                },
                // end Lasagna

                // start Croissant
                new Ingredient
                {
                    Id = Guid.Parse("5f9a6e7b-3c4d-8a1f-7b2d-6b9e7f3a5c12"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Name = "All-purpose flour",
                    Quantity = 3,
                    Measurement = "cups"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7a6b9e5f-3c4d-8a1f-7b2d-9f6e7c5b3a18"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Name = "Unsalted butter",
                    Quantity = 1,
                    Measurement = "cup"
                },
                new Ingredient
                {
                    Id = Guid.Parse("6f9c7b5a-3e4d-8a1f-7b2d-5a7e6f3b9c12"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Name = "Yeast",
                    Quantity = 2,
                    Measurement = "teaspoons"
                },
                new Ingredient
                {
                    Id = Guid.Parse("3a6f9e7b-5c4d-8a1f-7b2d-6e5f9b7c3a12"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Name = "Milk (warm)",
                    Quantity = 1,
                    Measurement = "cup"
                },
                // end Croissant

                // start Shawarma
                new Ingredient
                {
                    Id = Guid.Parse("5c4e7b9f-2d4a-8f3b-7b2c-9a5f6a7b3e12"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Name = "Chicken thighs (boneless)",
                    Quantity = 1,
                    Measurement = "pound"
                },
                new Ingredient
                {
                    Id = Guid.Parse("7a5b9f6e-5c4d-8a1f-7b2c-9e7a5c9b6f18"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Name = "Garlic cloves (minced)",
                    Quantity = 3,
                    Measurement = "cloves"
                },
                new Ingredient
                {
                    Id = Guid.Parse("8a9f6b7e-5c4d-8a1f-7b2d-6e7a5f9c3e12"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Name = "Ground cumin",
                    Quantity = 2,
                    Measurement = "teaspoons"
                },
                new Ingredient
                {
                    Id = Guid.Parse("9f7e8c5b-3c4d-8a1f-7b2d-9e5f7a6c3b12"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Name = "Yogurt (plain)",
                    Quantity = 1,
                    Measurement = "cup"
                },
                // end Shawarma
            };
        }
    }
}