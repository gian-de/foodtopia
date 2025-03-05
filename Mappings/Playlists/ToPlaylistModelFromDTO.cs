using foodtopia.DTOs.Playlist;
using foodtopia.Models;

namespace foodtopia.Mappings.Playlists
{
    public static class PlaylistCreate
    {
        public static Playlist ToPlaylistModelFromDTO(this PlaylistCreateRequestDTO playlistRequestDTO)
        {
            return new Playlist
            {
                // FullSlug and UserId are set in the service method
                Name = playlistRequestDTO.Name,
                SlugText = playlistRequestDTO.SlugText,
                SlugNumber = playlistRequestDTO.SlugNumber.Value,
            };
        }
    }
}