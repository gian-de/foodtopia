using System.ComponentModel.DataAnnotations;

namespace foodtopia.Models
{
    public class Instruction
    {
        public Guid Id { get; set; }
        public Guid RecipeId { get; set; }

        [Required(ErrorMessage = "Cannot be left blank.")]
        [StringLength(600, MinimumLength = 3, ErrorMessage = "Must be longer than 3 and shorter than 600 characters.")]
        public required int Order { get; set; }
        public required string Text { get; set; }
        public Recipe? Recipe { get; set; }
    }
}