using foodtopia.DTOs.Playlist;
using foodtopia.DTOs.Playlist.Submission;
using foodtopia.Helpers;

namespace foodtopia.Interfaces
{
    public interface IPlaylistService
    {
        Task<PagedResult<PlaylistSummaryDTO>> GetAllPlaylistsAsync(int page, int pageSize, string sortBy, string sortDirection);
        Task<PlaylistSummaryDTO> GetPlaylistByFullSlugAsync(string fullSlug);
        Task<PagedResult<PlaylistSummaryDTO>> GetMyCreatedPlaylistsAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection);
        Task<PlaylistSummaryDTO> CreatePlaylistAsync(Guid userId, PlaylistCreateRequestDTO playlistCreateDTO);
        Task<PlaylistSummaryDTO> UpdatePlaylistAsync(Guid userId, Guid playlistId, PlaylistUpdateRequestDTO playlistUpdateDTO);
        Task<PlaylistDeleteDTO> DeletePlaylistAsync(Guid userId, Guid playlistId);
        Task AddRecipeToPlaylistAsync(Guid userId, Guid playlistId, Guid recipeId);
        Task<bool> RemoveRecipeFromPlaylistAsync(Guid userId, Guid playlistId, Guid recipeId);

        Task<PagedResult<PlaylistSubmissionDetailsDTO>> GetMyPendingPlaylistsAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection);
        Task<PagedResult<PlaylistSubmissionDetailsDTO>> GetMyDeniedPlaylistsAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection);
        Task<PagedResult<PlaylistSubmissionDetailsDTO>> GetMyApprovedPlaylistsAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection);
        Task<PagedResult<PlaylistSubmissionHistoryDTO>> GetPlaylistSubmissionHistoryAsync(Guid userId, Guid playlistId, int page, int pageSize);


        Task<PlaylistSubmissionResponseDTO> SubmitPlaylistSubmissionAsync(Guid userId, Guid playlistId);
        Task<PlaylistSubmissionResponseDTO> UnSubmitPlaylistSubmissionAsync(Guid userId, Guid playlistId);
    }
}