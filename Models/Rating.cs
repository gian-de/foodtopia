using System.ComponentModel.DataAnnotations;

namespace foodtopia.Models
{
    public class Rating
    {
        public Guid Id { get; set; }
        public Guid RecipeId { get; set; }
        public Guid UserId { get; set; }
        [Range(1, 5, ErrorMessage = "Taste rating must be between 1 and 5")]
        public decimal TasteRating { get; set; }
        [Range(1, 5, ErrorMessage = "Difficulty rating must be between 1 and 5")]
        public decimal DifficultyRating { get; set; }
        public DateTime ReviewedAt { get; set; } = DateTime.UtcNow;

        public required Recipe Recipe { get; set; }
        public required User User { get; set; }
    }
}