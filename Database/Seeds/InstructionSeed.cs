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
                    Id = Guid.NewGuid(),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Step = "Crack eggs and add to mixing bowl.",
                    Order = 1
                },
                new Instruction
                {
                    Id = Guid.NewGuid(),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Step = "Whisk until eggs form into a foam-like white texture.",
                    Order = 2
                },
                new Instruction
                {
                    Id = Guid.NewGuid(),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Step = "Add arrowroot starch to mixing bowl and other spices of your choosing.",
                    Order = 3
                },
                new Instruction
                {
                    Id = Guid.NewGuid(),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Step = "Place inside the over that has been preheated to 350 degrees Fahrenheit for 8-10 minutes.",
                    Order = 4
                },
                new Instruction
                {
                    Id = Guid.NewGuid(),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Step = "Layer the sauce, then the cheese and lastly the toppings.",
                    Order = 5
                },
                new Instruction
                {
                    Id = Guid.NewGuid(),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Step = "Place back into the over for 12-15 minutes.",
                    Order = 6
                },
                new Instruction
                {
                    Id = Guid.NewGuid(),
                    RecipeId = RecipeSeedUUID.LowCaloriePizza,
                    Step = "Let the pizza cool for at least 5 minutes and enjoy!",
                    Order = 7
                },
            };
        }
    }
}