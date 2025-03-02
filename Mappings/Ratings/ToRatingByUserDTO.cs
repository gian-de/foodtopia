using foodtopia.DTOs.Country;
using foodtopia.DTOs.Rating;
using foodtopia.Models;

namespace foodtopia.Mappings.Ratings
{
    public static class RatingExtension
    {
        public static RatingByUserDTO ToRatingByUserDTO(this Rating ratingModel)
        {
            return new RatingByUserDTO
            (
                RecipeId: ratingModel.Recipe.Id,
                RecipeName: ratingModel.Recipe.Name,
                ImageUrl: ratingModel.Recipe.ImageUrl,
                TasteRating: ratingModel.TasteRating,
                DifficultyRating: ratingModel.DifficultyRating,
                ReviewedAt: ratingModel.ReviewedAt,
                Country: new CountryDTO
                            (
                                Id: ratingModel.Recipe.Country.Id,
                                Name: ratingModel.Recipe.Country.Name,
                                Slug: ratingModel.Recipe.Country.Slug,
                                ImagePath: ratingModel.Recipe.Country.ImagePath,
                                Recipes: null
                            )
            );
        }
    }
}