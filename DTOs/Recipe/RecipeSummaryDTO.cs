using foodtopia.DTOs.Country;
using foodtopia.DTOs.Ingredient;
using foodtopia.DTOs.Instruction;
using foodtopia.DTOs.User;

namespace foodtopia.DTOs.Recipe
{
    public record RecipeSummaryDTO
    (
        Guid Id,
        string Name,
        string ImageUrl,
        int HeartCount,
        double? TasteAverage,
        double? DifficultyAverage,
        int? TasteReviewCount,
        int? DifficultyReviewCount,
        DateTime PublishedAt,
        UserTldrDTO? User,
        Guid CountryId,
        CountryDTO Country,
        ICollection<IngredientDTO> Ingredients,
        ICollection<InstructionDTO> Instructions
    );
}