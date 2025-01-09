using foodtopia.DTOs.Recipe;

namespace foodtopia.DTOs.Country
{
    public record CountryDTO
    (
        Guid Id,
        string Name,
        string ImagePath,
        ICollection<RecipeTldrDTO> Recipes
    );
}