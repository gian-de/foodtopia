using foodtopia.DTOs.Country;

namespace foodtopia.DTOs.Recipe
{
    public record RecipeTldrDTO
    (
        Guid Id,
        string UserName,
        string Name,
        Guid CountryId,
        CountryDTO Country,
        string ImageUrl,
        decimal TasteAverage,
        decimal DifficultyAverage,
        int HeartCount
    );
}