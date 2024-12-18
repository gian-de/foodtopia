using System.ComponentModel.DataAnnotations;

namespace foodtopia.Models
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public Guid RecipeId { get; set; }
        [Required(ErrorMessage = "Ingredient name is required.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        public required decimal Quantity { get; set; }
        public string? Measurement { get; set; } = "";

        public Recipe? Recipe { get; set; }
    }
}