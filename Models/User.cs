using System.ComponentModel.DataAnnotations;

namespace foodtopia.Models
{
    public class User
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(28, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 28 characters long")]
        public required string Username { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public required string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public required string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        public required string Email { get; set; }
        public string Role { get; set; } = "none";

        [Required(ErrorMessage = "Password is required.")]
        public required string Password { get; set; }
        public bool IsDeleted { get; set; } = false;

        public required ICollection<HeartedRecipe> HeartedRecipes { get; set; }
        public required ICollection<Recipe> Recipes { get; set; }
        public required ICollection<Rating> Ratings { get; set; }

    }
}