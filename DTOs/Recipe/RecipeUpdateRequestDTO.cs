using foodtopia.DTOs.Ingredient;
using foodtopia.DTOs.Instruction;

namespace foodtopia.DTOs.Recipe
{
    public class RecipeUpdateRequestDTO
    {
        public string? Name { get; set; }
        public Guid? CountryId { get; set; }
        public string? ImageUrl { get; set; }
        public List<IngredientUpdateDTO>? Ingredients { get; set; }
        public List<InstructionUpdateDTO>? Instructions { get; set; }
    }
}