using foodtopia.DTOs.Playlist;
using foodtopia.Helpers;

namespace foodtopia.Interfaces
{
    public interface IPlaylistService
    {
        Task<PagedResult<PlaylistSummaryDTO>> GetAllPlaylistsAsync(int page, int pageSize, string sortBy, string sortDirection);
        Task<PlaylistSummaryDTO> GetPlaylistByIdAsync(Guid playlistId);
        Task<PagedResult<PlaylistSummaryDTO>> GetMyCreatedPlaylistsAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection);
    }
}