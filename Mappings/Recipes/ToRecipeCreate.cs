using foodtopia.DTOs.Recipe;
using foodtopia.Models;

namespace foodtopia.Mappings.Recipes
{
    public static class RecipeCreate
    {
        public static Recipe ToRecipeFromCreateDTO(this CreateRecipeRequestDTO recipeRequestDTO)
        {
            return new Recipe
            {
                Name = recipeRequestDTO.Name,
                CountryId = recipeRequestDTO.CountryId,
                // UserId = recipeRequestDTO.UserId,
                ImageUrl = recipeRequestDTO.ImageUrl,
                PublishedAt = recipeRequestDTO.PublishedAt,
                Ingredients = recipeRequestDTO.Ingredients.Select(ing => new Ingredient
                {
                    Name = ing.Name,
                    Quantity = ing.Quantity,
                    Measurement = ing.Measurement,
                }).ToList(),
                Instructions = recipeRequestDTO.Instructions.Select(ins => new Instruction
                {
                    Order = ins.Order,
                    Step = ins.Step
                }).ToList()
            };
        }
    }
}