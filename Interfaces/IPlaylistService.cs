using foodtopia.DTOs.Playlist;
using foodtopia.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace foodtopia.Interfaces
{
    public interface IPlaylistService
    {
        Task<PagedResult<PlaylistSummaryDTO>> GetAllPlaylistsAsync(int page, int pageSize, string sortBy, string sortDirection);
        Task<PlaylistSummaryDTO> GetPlaylistByIdAsync(Guid playlistId);
        Task<PagedResult<PlaylistSummaryDTO>> GetMyCreatedPlaylistsAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection);
        Task<PlaylistSummaryDTO> CreatePlaylistAsync(Guid userId, PlaylistCreateRequestDTO playlistCreateDTO);
        Task<PlaylistSummaryDTO> UpdatePlaylistAsync(Guid userId, Guid playlistId, PlaylistUpdateRequestDTO playlistUpdateDTO);
        Task<PlaylistDeleteDTO> DeletePlaylistAsync(Guid userId, Guid playlistId);
    }
}