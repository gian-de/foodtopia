namespace foodtopia.Models
{
    public class HeartedRecipe
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public required User User { get; set; }

        public Guid RecipeId { get; set; }
        public required Recipe Recipe { get; set; }

        public DateTime HeartedAt { get; set; } = DateTime.UtcNow;
    }
}