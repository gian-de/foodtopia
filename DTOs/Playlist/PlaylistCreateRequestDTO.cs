using System.ComponentModel.DataAnnotations;

namespace foodtopia.DTOs.Playlist
{
    public class PlaylistCreateRequestDTO
    {
        [Required]
        [MaxLength(75)]
        public string Name { get; set; } = default!;

        [Required]
        [MaxLength(32)]
        [RegularExpression(@"^[A-Za-z\s]+$")]
        public string SlugText { get; set; } = default!;

        [Required]
        [Range(0, 9999)]
        public int? SlugNumber { get; set; }
    }
}