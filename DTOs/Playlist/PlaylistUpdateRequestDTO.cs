using System.ComponentModel.DataAnnotations;

namespace foodtopia.DTOs.Playlist
{
    public class PlaylistUpdateRequestDTO
    {
        [MaxLength(75)]
        public string? Name { get; set; }

        [MaxLength(32)]
        [RegularExpression(@"^[A-Za-z\s]+$")]
        public string? SlugText { get; set; }

        [Range(0, 9999)]
        public int? SlugNumber { get; set; }
    }
}