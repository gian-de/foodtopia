using System.ComponentModel.DataAnnotations;

namespace foodtopia.Models
{
    public class Recipe
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be less than 100 characters.")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Image url is required.")]
        public required string ImageUrl { get; set; }
        public decimal TasteAverage { get; set; }
        public decimal DifficultyAverage { get; set; }
        public int TasteReviewCount { get; set; }
        public int DifficultyReviewCount { get; set; }
        public DateTime PublishedAt { get; set; } = DateTime.UtcNow;
        public string VisibilityStatus { get; set; } = "unlisted";
        public Guid? UserId { get; set; }
        public AppUser User { get; set; } = default!;
        public required Guid CountryId { get; set; }
        public Country Country { get; set; } = default!;
        public ICollection<HeartedRecipe> HeartedByUsers { get; set; } = new List<HeartedRecipe>();
        public required ICollection<Ingredient> Ingredients { get; set; }
        public required ICollection<Instruction> Instructions { get; set; }
        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
        public ICollection<PlaylistRecipe> PlaylistRecipes { get; set; } = new List<PlaylistRecipe>();
        public ICollection<VisibilityReview> VisibilityReviews { get; set; } = new List<VisibilityReview>();
    }
}