using foodtopia.Dtos.Recipe;
using foodtopia.DTOs.Country;
using foodtopia.DTOs.Ingredient;
using foodtopia.DTOs.Instruction;
using foodtopia.DTOs.Rating;
using foodtopia.DTOs.User;
using foodtopia.Models;

namespace foodtopia.Mappings.Recipes
{
    public static class RecipeExtension
    {
        public static RecipeSummaryDTO ToRecipeSummaryDTO(this Recipe recipeModel)
        {
            return new RecipeSummaryDTO(
                Id: recipeModel.Id,
                Name: recipeModel.Name,
                ImageUrl: recipeModel.ImageUrl,
                HeartCount: recipeModel.HeartedByUsers?.Count() ?? 0,
                TasteAverage: recipeModel.TasteAverage,
                DifficultyAverage: recipeModel.DifficultyAverage,
                TasteReviewCount: recipeModel.TasteReviewCount,
                DifficultyReviewCount: recipeModel.DifficultyReviewCount,
                PublishedAt: recipeModel.PublishedAt,
                User: recipeModel.User != null
                    ? new UserTldrDTO(
                        recipeModel.User.Id,
                        recipeModel.User.Username,
                        recipeModel.User.IsDeleted
                        )
                    : null,
                CountryId: recipeModel.CountryId,
                Country: new CountryDTO(
                    Id: recipeModel.Country.Id,
                    Name: recipeModel.Country.Name,
                    Slug: recipeModel.Country.Slug,
                    ImagePath: recipeModel.Country.ImagePath,
                    Recipes: null
                ),
                Ingredients: recipeModel.Ingredients.Select(ing => new IngredientDTO(ing.Id, ing.Name, ing.Quantity, ing.Measurement)).ToList(),
                Instructions: recipeModel.Instructions.Select(inst => new InstructionDTO(inst.Id, inst.Step, inst.Order)).ToList(),
                Ratings: recipeModel.Ratings?.Select(r => new RatingDTO(
                                                        r.Id,
                                                        r.TasteRating,
                                                        r.DifficultyRating)).ToList()
                                                        ?? new List<RatingDTO>()
            );
        }
    }
}