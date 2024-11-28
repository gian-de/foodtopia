namespace foodtopia.Models
{
    public class Rating
    {
        public Guid Id { get; set; }
        public Guid RecipeId { get; set; }
        public Guid UserId { get; set; }

        public decimal TasteRating { get; set; }
        public decimal DifficultyRating { get; set; }
        public DateTime ReviewedAt { get; set; } = DateTime.UtcNow;

        public required Recipe Recipe { get; set; }
        public required User User { get; set; }
    }
}