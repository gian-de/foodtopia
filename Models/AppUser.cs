using Microsoft.AspNetCore.Identity;

namespace foodtopia.Models
{
    public class AppUser : IdentityUser<Guid>
    {
        public bool IsGuest { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
        public ICollection<HeartedRecipe> HeartedRecipes { get; set; } = new List<HeartedRecipe>();
        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
        public ICollection<Playlist> Playlists { get; set; } = new List<Playlist>();
        public ICollection<HeartedPlaylist> HeartedPlaylists { get; set; } = new List<HeartedPlaylist>();
    }
}