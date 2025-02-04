namespace foodtopia.Models
{
    public class HeartedRecipe
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public AppUser? User { get; set; }

        public Guid RecipeId { get; set; }
        public Recipe? Recipe { get; set; }

        public DateTime HeartedAt { get; set; } = DateTime.UtcNow;
    }
}