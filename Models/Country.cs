using System.ComponentModel.DataAnnotations;

namespace foodtopia.Models
{
    public class Country
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        [Required]
        [Url(ErrorMessage = "Image must be a valid URL.")]
        public required string ImagePath { get; set; }
        public required string Slug { get; set; }
        public ICollection<Recipe>? Recipes { get; set; }
    }
}