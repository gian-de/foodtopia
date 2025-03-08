namespace foodtopia.Models
{
    public class VisibilityReview
    {
        public Guid Id { get; set; }
        public string VisibilityStatus { get; set; } = "pending";
        public string? ReviewFeedback { get; set; }
        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ReviewedAt { get; set; }
        public Guid? ReviewedById { get; set; }
        public AppUser? ReviewedBy { get; set; }

        public Guid? RecipeId { get; set; }
        public Recipe? Recipe { get; set; }

        public Guid? PlaylistId { get; set; }
        public Playlist? Playlist { get; set; }
    }
}