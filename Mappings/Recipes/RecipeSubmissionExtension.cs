using foodtopia.DTOs.Country;
using foodtopia.DTOs.Ingredient;
using foodtopia.DTOs.Instruction;
using foodtopia.DTOs.Recipe.Submission;
using foodtopia.Models;

namespace foodtopia.Mappings.Recipes
{
    public static class RecipeSubmissionExtension
    {
        public static RecipeSubmissionDetailsDTO ToRecipeSubmissionDetailsDTO(this Recipe recipeModel, string visibilityStatusArgument)
        {
            // var visibilityReview = recipeModel.VisibilityReviews.FirstOrDefault(vr => vr.VisibilityStatus.ToLower() == visibilityStatusArgument.ToLower());
            var visibilityReview = recipeModel.VisibilityReviews
                                    .Where(vr => vr.VisibilityStatus.ToLower() == visibilityStatusArgument.ToLower())
                                    .OrderByDescending(vr => vr.SubmittedAt)
                                    .FirstOrDefault();

            return new RecipeSubmissionDetailsDTO(
                RecipeId: recipeModel.Id,
                Name: recipeModel.Name,
                ImageUrl: recipeModel.ImageUrl,
                VisibilityStatus: recipeModel.VisibilityStatus,
                HeartCount: recipeModel.HeartedByUsers?.Count ?? 0,
                TasteAverage: recipeModel.Ratings?.Count > 0 ? Math.Round(recipeModel.Ratings.Average(r => r.TasteRating), 2) : null,
                DifficultyAverage: recipeModel.Ratings?.Count > 0 ? Math.Round(recipeModel.Ratings.Average(r => r.DifficultyRating), 2) : null,
                TasteReviewCount: recipeModel.Ratings?.Count(r => r.TasteRating > 0),
                DifficultyReviewCount: recipeModel.Ratings?.Count(r => r.DifficultyRating > 0),
                PublishedAt: recipeModel.PublishedAt,
                SubmittedAt: visibilityReview?.SubmittedAt,
                ReviewedAt: visibilityReview?.ReviewedAt,
                ReviewedByUsername: visibilityReview?.ReviewedBy?.UserName,
                CountryId: recipeModel.CountryId,
                Country: new CountryDTO(
                    Id: recipeModel.Country!.Id,
                    Name: recipeModel.Country.Name,
                    Slug: recipeModel.Country.Slug,
                    ImagePath: recipeModel.Country.ImagePath,
                    Recipes: null
                ),
                Ingredients: recipeModel.Ingredients.Select(ing => new IngredientDTO(ing.Id, ing.Name, ing.Quantity, ing.Measurement)).ToList(),
                Instructions: recipeModel.Instructions.Select(inst => new InstructionDTO(inst.Id, inst.Order, inst.Text)).ToList()
            );
        }
    }
}