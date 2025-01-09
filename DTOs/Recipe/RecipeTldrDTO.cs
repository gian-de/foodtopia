using foodtopia.Models;

namespace foodtopia.DTOs.Recipe
{
    public record RecipeTldrDTO
    (

        Guid Id,
        string Name,
        string CountryId,
        string ImageUrl,
        int HeartCount,
        decimal TasteAverage,
        decimal DifficultyAverage
    );
}