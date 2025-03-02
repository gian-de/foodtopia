using foodtopia.DTOs.Country;

namespace foodtopia.DTOs.Rating
{
    public record RatingByUserDTO
    (
        Guid RecipeId,
        string RecipeName,
        string ImageUrl,
        double TasteRating,
        double DifficultyRating,
        DateTime ReviewedAt,
        CountryDTO Country
    );
}