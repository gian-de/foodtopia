using foodtopia.Models;

namespace foodtopia.Database.Seeds
{
    public static class InstructionSeed
    {
        public static IEnumerable<Instruction> GetInstructions()
        {
            return new List<Instruction>()
            {
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
            };
        }
    }
}