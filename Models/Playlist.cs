using System.ComponentModel.DataAnnotations;

namespace foodtopia.Models
{
    public class Playlist
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Playlist name is required.")]
        [MaxLength(75, ErrorMessage = "Playlist name cannot be more than 75 characters.")]
        public string Name { get; set; } = default!;

        [Required(ErrorMessage = "Slug text is required.")]
        [MaxLength(32, ErrorMessage = "Slug text cannot be more than 32 characters. ")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Slug text can only contain letters and spaces.")]
        public string SlugText { get; set; } = default!;

        [Range(0, 9999, ErrorMessage = "Slug number must be between 0 and 9999.")]
        public int SlugNumber { get; set; }

        public string FullSlug { get; set; } = default!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string VisibilityStatus { get; set; } = "private";

        public Guid UserId { get; set; }
        public AppUser User { get; set; } = default!;

        public ICollection<PlaylistRecipe> PlaylistRecipes { get; set; } = new List<PlaylistRecipe>();
        public ICollection<HeartedPlaylist> HeartedByUsers { get; set; } = new List<HeartedPlaylist>();
        public ICollection<VisibilityReview> VisibilityReviews { get; set; } = new List<VisibilityReview>();
    }
}