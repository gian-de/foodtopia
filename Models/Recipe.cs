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
        public int HeartCount { get; set; } = 0;
        public decimal TasteAverage { get; set; }
        public decimal DifficultyAverage { get; set; }
        public int TasteReviewCount { get; set; }
        public int DifficultyReviewCount { get; set; }
        public DateTime PublishedAt { get; set; } = DateTime.UtcNow;

        [Required(ErrorMessage = "Country origin is required.")]
        public required string CountryId { get; set; }
        public Country? CountryOrigin { get; set; } // this is used as a navigational property and to populate the imgpath also with having to chain an addition .include sql statement
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public ICollection<HeartedRecipe>? HeartedByUsers { get; set; }
        public required ICollection<Ingredient> Ingredients { get; set; }
        public required ICollection<Instruction> Instructions { get; set; }
        public ICollection<Rating>? Ratings { get; set; }
    }
}