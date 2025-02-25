namespace foodtopia.Models
{
    public class HeartedPlaylist
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get; set; } = default!;

        public Guid PlaylistId { get; set; }
        public Playlist Playlist = default!;

        public DateTime HeartedAt { get; set; } = DateTime.UtcNow;
    }
}