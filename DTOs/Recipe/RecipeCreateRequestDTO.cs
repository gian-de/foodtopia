using foodtopia.DTOs.Ingredient;
using foodtopia.DTOs.Instruction;

namespace foodtopia.DTOs.Recipe
{
    public class RecipeCreateRequestDTO
    {
        public string Name { get; set; }
        public Guid CountryId { get; set; }
        public string ImageUrl { get; set; }
        public List<IngredientCreateDTO> Ingredients { get; set; } = new();
        public List<InstructionCreateDTO> Instructions { get; set; } = new();
        public DateTime PublishedAt { get; set; } = DateTime.UtcNow;
    }
}