using foodtopia.Models;

namespace foodtopia.Dtos.Recipe
{
    public record RecipeSummaryDTO
    (
        Guid Id,
        string Name,
        Guid CountryId,
        string ImageUrl,
        int HeartCount,
        decimal TasteAverage,
        decimal DifficultyAverage,
        int TasteReviewCount,
        int DifficultyReviewCount,
        DateTime PublishedAt,
        User User,
        ICollection<Ingredient> Ingredients,
        ICollection<Instruction> Instructions,
        ICollection<Rating> Ratings,
        // add as num next to heart icon
        ICollection<HeartedRecipe> HeartedByUsersCount
    );
}