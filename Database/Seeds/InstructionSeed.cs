using foodtopia.Models;

namespace foodtopia.Database.Seeds
{
    public static class InstructionSeed
    {
        public static IEnumerable<Instruction> GetInstructions()
        {
            return new List<Instruction>()
            {
                // start Low Cal Pizza
                new Instruction
                {
                    Id = Guid.Parse("a1d3bbaf-1132-4111-b558-2e027fab8926"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Step = "Crack eggs and add to mixing bowl.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("7cc01c97-66e0-40e3-9e0b-67cb7e5bba8c"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Step = "Whisk until eggs form into a foam-like white texture.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("dbb31e0c-0758-40a2-a7fb-d7e2499befa0"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Step = "Add arrowroot starch to mixing bowl and other spices of your choosing.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("19e6a008-bc94-4bff-8fd7-8b633712f9b9"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Step = "Place inside the over that has been preheated to 350 degrees Fahrenheit for 8-10 minutes.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("e662eb34-f212-424e-a5c5-186954c01f4a"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Step = "Layer the sauce, then the cheese and lastly the toppings.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.Parse("bc6b146f-9f96-4e1f-8cc0-26b139d5ef1a"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Step = "Place back into the over for 12-15 minutes.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.Parse("53c53fa8-b7c7-47aa-8bd4-6880cee51f01"),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Step = "Let the pizza cool for at least 5 minutes and enjoy!",
                    Order = 7
                },
                // end Low Cal Pizza

                // start Classic Cheeseburger
                new Instruction
                {
                    Id = Guid.Parse("a3a2d1d5-b8d2-4095-9dab-a6ece4e8a12b"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Step = "Shape ground beef into four patties.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("2470414b-0fb5-4714-807f-bd0e58961f2d"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Step = "Grill patties for 3-4 minutes per side.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("d0f47451-500b-45b5-bfdd-610c268e815b"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Step = "Place cheddar cheese slices on patties to melt.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("1333c52f-b6a9-499d-a34a-c9ca5b2da74e"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Step = "Toast burger buns lightly on the grill.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("53774383-64e6-4fc6-a307-3316e2f2527d"),
                    RecipeId = RecipeSeedUUID.ClassicCheeseburger,
                    Step = "Assemble burgers with lettuce, patties, and toppings of choice.",
                    Order = 5
                },
                // end Classic Cheeseburger

                // start Tacos al Pastor
                new Instruction
                {
                    Id = Guid.Parse("a8d91f07-ba9d-4bc2-a648-3e19e2863559"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Step = "Marinate pork in adobo sauce for 4 hours.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("5122c450-7627-47f4-a1cd-aa2fe8773ebf"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Step = "Grill pork until fully cooked and slightly charred.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("7d465672-a6a1-4981-af70-6f3d9754370a"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Step = "Chop grilled pork into bite-sized pieces.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("f7542ebf-4f93-4556-93ee-8a2184a7fddc"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Step = "Warm tortillas on a skillet or grill.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("03e9f8e6-539c-41e7-a041-8af500790ba7"),
                    RecipeId = RecipeSeedUUID.TacosAlPastor,
                    Step = "Assemble tacos with pork, pineapple, and toppings of choice.",
                    Order = 5
                },
                // end Tacos al Pastor

                // start Chicken Biryani
                new Instruction
                {
                    Id = Guid.Parse("ebc08345-ecbc-43cc-a371-ed082f332976"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Step = "Marinate chicken with yogurt and spices for 2 hours.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("4f6b3424-78dd-4b4d-af57-d001e42bc3c3"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Step = "Cook basmati rice until half-cooked and drain.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("b6790a8b-3c8a-4905-849b-d80ca468096f"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Step = "Layer chicken and rice in a pot, adding fried onions.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("43f35046-194d-414c-909c-ec7a0fad643c"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Step = "Seal the pot with a lid and cook on low heat for 30 minutes.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("7ab0a7aa-0a00-4cc0-90f8-e4c808962230"),
                    RecipeId = RecipeSeedUUID.ChickenBiryani,
                    Step = "Fluff rice and serve hot with raita.",
                    Order = 5
                },
                // end Chicken Biryani

                // start Pecking Duck
                new Instruction
                {
                    Id = Guid.Parse("e8f2d9d7-b6c7-4c9e-b79f-75d19a5f5f8b"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Step = "Clean and dry the duck thoroughly.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("db49a2e1-4f37-4b5d-b8a1-6a9cbf3e43c6"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Step = "Roast the duck in the oven at 375°F until crispy.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("5c8a2f37-dc8b-4c69-a8a1-6c35e8c7b4f3"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Step = "Slice the duck into thin pieces.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("d4b29f68-4e8b-4a5f-a2c8-7b34f9e6c3a5"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Step = "Spread hoisin sauce on the pancakes.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("6b8c3d74-5c4a-4b8d-b3a7-9f6e5c8a2d5b"),
                    RecipeId = RecipeSeedUUID.PekingDuck,
                    Step = "Assemble pancakes with duck, scallions, and serve.",
                    Order = 5
                },
                // end Pecking Duck

                // start Beef Stroganoff
                new Instruction
                {
                    Id = Guid.Parse("9f7a6e5b-3c4d-8a1f-7b2d-5a6e7c8b9e12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Step = "Cook beef in a pan until browned, then set aside.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("7a9f5c6e-4e3d-8a1f-7b2d-9b6e7f5a7b12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Step = "Sauté onions and mushrooms in the same pan.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("8b7c9e5a-3c4d-8a1f-7b2d-9e6f7b5a3b12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Step = "Add beef back into the pan and stir in beef broth.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("6c9e7f3b-3c4d-8a1f-7b2d-5f7b9c6a3f12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Step = "Stir in sour cream and simmer for 5 minutes.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("5a6f9c8e-3c4d-8a1f-7b2d-9e7f6b7a5e12"),
                    RecipeId = RecipeSeedUUID.BeefStroganoff,
                    Step = "Serve over egg noodles or rice.",
                    Order = 5
                },
                // end Beef Stroganoff
                
                // start Feijoada
                new Instruction
                {
                    Id = Guid.Parse("7b24c93f-4f3d-4c92-93a7-3b25d9e8f4a2"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Step = "Soak black beans in water overnight.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("1cf7d59b-3a6f-4c35-b8e2-9c7245b39f8c"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Step = "Cook black beans with bay leaves until tender.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("4e9b3d82-7f6c-4d5f-83a2-7c38b25f9b6d"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Step = "Sear sausage and pork ribs in a skillet.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("6c82d49f-3b6e-4c7f-93f5-8b25d39c7e48"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Step = "Combine meats with cooked beans and simmer.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("1f7b49c3-83e5-4c6b-b724-9d38c35a9f8d"),
                    RecipeId = RecipeSeedUUID.Feijoada,
                    Step = "Serve hot with white rice and orange slices.",
                    Order = 5
                },
                // end Feijoada

                // start Sushi
                new Instruction
                {
                    Id = Guid.Parse("aa70a518-abf1-40d5-b54f-13863ef82212"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Step = "Cook sushi rice and season with rice vinegar.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("4980a006-6a16-4788-bc52-c1aab9215845"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Step = "Place a nori sheet on a bamboo mat.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("bf1e4571-675f-44bf-9f3e-b8e572d0a7d1"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Step = "Spread rice evenly on the nori, leaving an edge.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("62f1b272-5cbf-4ba8-9ad6-2abdd4f1b865"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Step = "Add fresh salmon and roll tightly.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("2ada858b-3049-488e-891e-7c4eca8ea28f"),
                    RecipeId = RecipeSeedUUID.Sushi,
                    Step = "Slice roll into bite-sized pieces and serve with soy sauce.",
                    Order = 5
                },
                // end Sushi

                // start Pad Thai
                new Instruction
                {
                    Id = Guid.Parse("d9eac06b-58d7-41c2-b6db-6d14e98e3914"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Step = "Soak rice noodles in warm water until softened.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("a68d3b3f-2460-49ff-a469-15d5b0f8c03c"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Step = "Cook shrimp in a hot wok until pink, then set aside.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("e349c5be-9f1c-4fbf-8497-142e6c64e2cc"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Step = "Add soaked noodles to the wok with Pad Thai sauce.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("c915df33-f7c6-4f55-ae59-9b8d1e36d446"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Step = "Stir in shrimp and bean sprouts.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("96e0bcb2-49f6-4745-8125-5c63e136f5b7"),
                    RecipeId = RecipeSeedUUID.PadThai,
                    Step = "Serve hot with lime wedges and crushed peanuts.",
                    Order = 5
                },
                // end Pad Thai

                // start Pho
                new Instruction
                {
                    Id = Guid.Parse("2f5b7c4a-6e8d-3f92-83b9-7a39e2c5d8f6"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Step = "Cook rice noodles according to package instructions.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("5a39e7d6-4f92-3b8c-83f7-7d2e5b6f4a3c"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Step = "Heat beef broth and bring to a gentle boil.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("7c5b92e6-3f4a-96d7-2b8f-5a39e4f7c8d3"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Step = "Add thinly sliced beef to the hot broth.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("8d4b3f5a-7e96-2b8f-83c9-4a7d5c39f6e2"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Step = "Combine cooked noodles and broth in a bowl.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("3f6b7c92-5a9d-4b2e-96e7-4a39f5d8c7e3"),
                    RecipeId = RecipeSeedUUID.Pho,
                    Step = "Garnish with bean sprouts, herbs, and lime wedges.",
                    Order = 5
                },
                // end Pho

                // start Ceviche
                new Instruction
                {
                    Id = Guid.Parse("8f5b9c4a-3d7e-6a2f-7f3b-4c9a7f5e8b6d"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Step = "In a bowl, combine fish and lime juice.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("7d4c9b6f-3e8a-5f2f-7f3a-9c5e7b4a6f8d"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Step = "Let the fish marinate in the lime juice for 10 minutes.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("6a7c5f3d-9b4e-8f2f-7f9d-3b5e7a4c8f6d"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Step = "Add sliced red onion and cilantro to the marinated fish.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("5e9a7b6f-4c3a-8f2f-7f5d-3b9c7e6a4f8d"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Step = "Toss everything together gently.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("4b7a6f9e-3d5c-8f2f-7f3a-9c5e7b4a8f6d"),
                    RecipeId = RecipeSeedUUID.Ceviche,
                    Step = "Serve immediately with tortilla chips or on its own.",
                    Order = 5
                },
                // end Ceviche

                // start Kebab
                new Instruction
                {
                    Id = Guid.Parse("d3a97b62-fab2-4e8a-96fc-1b8a49f7e283"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Step = "Combine ground lamb, grated onion, cumin, and salt in a bowl.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("7a96b41d-e289-4cf8-b27a-6f91c3b7d0f4"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Step = "Shape the mixture into long, thin patties or onto skewers.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("f4d7293a-5b9f-4e91-8a2c-7b18d6e2f049"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Step = "Preheat grill or grill pan to medium-high heat.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("9b3c78fa-6d8e-4a1f-b2d7-3a9c47e6f0a8"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Step = "Cook kebabs for 3-4 minutes on each side until fully cooked.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("6f8c4a97-b5e3-4981-9d2a-7e0f9c3a621b"),
                    RecipeId = RecipeSeedUUID.Kebab,
                    Step = "Serve with flatbread, yogurt, and fresh vegetables.",
                    Order = 5
                },
                // end Kebab

                // start Butter Chicken
                new Instruction
                {
                    Id = Guid.Parse("5e9a7f6d-b34c-4f91-8a7d-9b6f2a0c7f18"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Step = "Melt butter in a skillet over medium heat.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("6f7c4b5d-a92e-8f31-7b9d-3a9c7e6f4d12"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Step = "Add chicken and cook until browned.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("7b8f9a3d-4e6f-1b2c-7a5f-6c9f4e7d3a18"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Step = "Stir in tomato puree and heavy cream.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("4a3d5e6b-9f8c-7a1f-3b7d-9e6f4a91c5b8"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Step = "Simmer on low heat for 10-15 minutes.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("6f5b7d9e-3a2c-8f1b-9d7a-4e6c9a5f8b12"),
                    RecipeId = RecipeSeedUUID.ButterChicken,
                    Step = "Serve with basmati rice or naan bread.",
                    Order = 5
                },
                // end Butter Chicken

                // start Bobotie
                new Instruction
                {
                    Id = Guid.Parse("7b6f9a4e-3a8c-5f1d-9e2b-6a7d4f3e5c9a"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Step = "Preheat the oven to 350°F (175°C).",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("5f3b7d4a-9e8c-6a1f-7b2d-3f6e5c9a7b18"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Step = "Sauté onions in a skillet until translucent.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("3e7f5b9a-1c4d-6a8b-9f2e-5a6d7b4c9f18"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Step = "Mix onions, ground beef, bread, and curry powder in a bowl.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("9e3f6b7a-4a1d-7c5b-9f8e-6a3d5f7b8c12"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Step = "Transfer the mixture to a greased baking dish.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("4f3b9d7a-6a8c-5e1f-7b2d-3f9a5c7e8b18"),
                    RecipeId = RecipeSeedUUID.Bobotie,
                    Step = "Bake for 30-40 minutes until golden brown.",
                    Order = 5
                },
                // end Bobotie

                // start Kimchi
                new Instruction
                {
                    Id = Guid.Parse("6a7b9d3f-5e8c-4f1b-7a2d-9c6e3f5b7a18"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Step = "Chop cabbage and sprinkle with salt. Let it sit for 2 hours.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("3e5b7a4c-9f6d-7b1f-7a2d-6a8c9e5f3b12"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Step = "Rinse the cabbage thoroughly to remove excess salt.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("9f6c7b3a-4d5e-8a1f-7b2c-6e9a5f7b3c18"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Step = "Mix cabbage with chili flakes, garlic, and water to create a paste.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("4a7d5b6f-3c9e-7a1f-7b2d-6f9c5e7a3b18"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Step = "Pack the mixture tightly into a jar.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("7e3f5b9a-4a6c-8f1d-7b2d-3f9c5e7a6b12"),
                    RecipeId = RecipeSeedUUID.Kimchi,
                    Step = "Ferment at room temperature for 3-5 days, then refrigerate.",
                    Order = 5
                },
                // end Kimchi

                // start Pierogi
                new Instruction
                {
                    Id = Guid.Parse("5e7b9c6a-3d4f-8a1b-7f2c-9a6f5b3e7a12"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Step = "Mix flour, egg, and water to form a dough. Knead until smooth.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("9f3b7e5a-6d4c-8a1f-7b2d-3f6a7b5c9e12"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Step = "Roll out dough and cut into circles using a cookie cutter.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("4f7c9a6e-5d3b-1a8f-7b2c-9e6a5f3b7a18"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Step = "Spoon mashed potato and cheese filling onto each circle.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("3e7b9f6c-5a4d-8a1f-7b2c-6a9e5f7c3b12"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Step = "Fold the dough over the filling and pinch edges to seal.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("7a6f5b9e-3c4d-8a1f-7b2d-6f9c5e3b7a18"),
                    RecipeId = RecipeSeedUUID.Pierogi,
                    Step = "Boil in salted water for 5-7 minutes, then serve warm.",
                    Order = 5
                },
                // end Pierogi

                // start Fish and Chips
                new Instruction
                {
                    Id = Guid.Parse("7a9c6f5b-3e4d-8a1f-7b2d-9f6e5b3a7c12"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Step = "Heat oil in a deep fryer or heavy skillet.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("3e7f5b9a-6c4d-8a1f-7b2d-6f9a7b5c3e18"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Step = "Coat fish fillets with flour, then dip in batter.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("6a9b5f7c-3e4d-8a1f-7b2d-9f6e7c5a3b18"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Step = "Fry the fish in hot oil until golden brown.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("4b7a6f3e-5c9d-1a8f-7b2c-6e9a5f3b7a18"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Step = "Fry the potato fries until crispy and golden.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("9f6a5b7e-3c4d-8a1f-7b2d-6e9a5c3f7b12"),
                    RecipeId = RecipeSeedUUID.FishAndChips,
                    Step = "Serve fish and chips together with tartar sauce.",
                    Order = 5
                },
                // end Fish and Chips

                // start Moussaka
                new Instruction
                {
                    Id = Guid.Parse("8a9b7f6c-3e4d-1a8f-7b2d-6e9a5c7b3f12"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Step = "Preheat oven to 375°F (190°C).",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("3b6e7a5f-9c4d-8a1f-7b2d-5e7f9a6c3b12"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Step = "Cook eggplant slices in olive oil until soft and lightly browned.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("7e5a6f3b-9c4d-8a1f-7b2d-6a9f5c7e3b18"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Step = "Cook ground lamb with diced tomatoes and season to taste.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("9e7b5a6f-3c4d-8a1f-7b2d-5f9a6e7b3a12"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Step = "Layer eggplants and lamb mixture in a baking dish.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("5b9e7a6f-3c4d-8a1f-7b2d-6e7a5f3b9c18"),
                    RecipeId = RecipeSeedUUID.Moussaka,
                    Step = "Top with béchamel sauce and bake for 30-40 minutes.",
                    Order = 5
                },
                // end Moussaka

                // start Lasagna
                new Instruction
                {
                    Id = Guid.Parse("7f5a6e9b-3c4d-8a1f-7b2d-9e6a5c7f3b12"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Step = "Preheat oven to 375°F (190°C).",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("9b5e7f6a-3c4d-8a1f-7b2d-6a7c9e5f3b18"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Step = "Cook lasagna noodles according to package instructions.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("3e9a6b7f-5c4d-8a1f-7b2d-5f7c9a6e3b12"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Step = "Cook ground beef and season with garlic and spices.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("6b5a9f7e-3c4d-8a1f-7b2d-9c7f6a5b3e12"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Step = "Layer noodles, ricotta, beef, and mozzarella in a baking dish.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("5f6b9e7a-3c4d-8a1f-7b2d-6e9a7b5c3f12"),
                    RecipeId = RecipeSeedUUID.Lasagna,
                    Step = "Bake for 35-40 minutes, then let rest before serving.",
                    Order = 5
                },
                // end Lasagna

                // start Croissant
                new Instruction
                {
                    Id = Guid.Parse("5f7e9a6b-3c4d-8a1f-7b2d-6a9f7b5c3e12"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Step = "Dissolve yeast in warm milk and let it activate.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("7b6f5a9e-3c4d-8a1f-7b2d-9e6f3a5c7b12"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Step = "Mix flour, sugar, salt, and milk mixture into a dough.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("9e7a6f3b-5c4d-8a1f-7b2d-5a6e9f7b3c12"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Step = "Fold butter into the dough and roll out several times.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("6a5e9f7b-3c4d-8a1f-7b2d-7b5f9e6c3a12"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Step = "Shape into croissants and let them proof until doubled.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("7f5b6a9e-3c4d-8a1f-7b2d-9e6a3f7b5c12"),
                    RecipeId = RecipeSeedUUID.Croissant,
                    Step = "Bake at 400°F (200°C) until golden brown and flaky.",
                    Order = 5
                },
                // end Croissant

                // start Shawarma
                new Instruction
                {
                    Id = Guid.Parse("6a9f7e5b-3c4d-8a1f-7b2d-8f6b7c9f3e12"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Step = "Mix yogurt, garlic, cumin, and olive oil to create marinade.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.Parse("8b9f7e5a-3c4d-8a1f-7b2d-5c7e6a5f3b12"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Step = "Marinate chicken in the mixture for at least 2 hours.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.Parse("9c8a5b7f-3c4d-8a1f-7b2d-6f7a5c9b3a12"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Step = "Grill chicken on medium-high heat for about 5-7 minutes per side.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.Parse("4f6e8c7b-3c4d-8a1f-7b2d-9e5a7f9b3c12"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Step = "Rest chicken for a few minutes, then slice thinly.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.Parse("7b9f6c7e-3c4d-8a1f-7b2d-5a9e6b7c9f12"),
                    RecipeId = RecipeSeedUUID.Shawarma,
                    Step = "Serve with pita and your favorite toppings.",
                    Order = 5
                },
                // end Shawarma
            };
        }
    }
}