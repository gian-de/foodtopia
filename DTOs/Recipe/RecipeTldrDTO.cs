using foodtopia.Models;

namespace foodtopia.DTOs.Recipe
{
    public record RecipeTldrDTO
    (
        Guid Id,
        string Name,
        Guid CountryId,
        string ImageUrl,
        decimal TasteAverage,
        decimal DifficultyAverage,
        int HeartCount
    );
}