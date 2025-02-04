using Microsoft.AspNetCore.Identity;

namespace foodtopia.Models
{
    public class AppUser : IdentityUser<Guid>
    {
        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
        public ICollection<HeartedRecipe> HeartedRecipes { get; set; } = new List<HeartedRecipe>();
        public ICollection<Rating> Ratings { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}