using System.ComponentModel.DataAnnotations;

namespace foodtopia.DTOs.Playlist
{
    public class PlaylistCreateRequestDTO
    {
        [MaxLength(75)]
        public string Name { get; set; } = default!;

        [MaxLength(32)]
        [RegularExpression(@"^[A-Za-z\s]+$")]
        public string SlugText { get; set; } = default!;

        [Range(0, 9999)]
        public int SlugNumber { get; set; }
    }
}