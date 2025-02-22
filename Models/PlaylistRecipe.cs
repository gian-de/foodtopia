namespace foodtopia.Models
{
    public class PlaylistRecipe
    {
        public Guid PlaylistId { get; set; }
        public Playlist Playlist { get; set; } = default!;

        public Guid RecipeId { get; set; }
        public Recipe Recipe { get; set; } = default!;
    }
}