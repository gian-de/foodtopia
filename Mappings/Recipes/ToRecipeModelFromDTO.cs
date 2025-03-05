using foodtopia.DTOs.Recipe;
using foodtopia.Models;

namespace foodtopia.Mappings.Recipes
{
    public static class RecipeCreate
    {
        public static Recipe ToRecipeModelFromDTO(this RecipeCreateRequestDTO recipeRequestDTO)
        {
            return new Recipe
            {
                // UserId is set in the service method
                Name = recipeRequestDTO.Name,
                CountryId = recipeRequestDTO.CountryId,
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
                    Text = ins.Text
                }).ToList()
            };
        }
    }
}