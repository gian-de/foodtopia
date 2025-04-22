using foodtopia.DTOs.Admin.Moderator;
using foodtopia.DTOs.Playlist;
using foodtopia.DTOs.Recipe;
using foodtopia.Helpers;

namespace foodtopia.Interfaces.Admin
{
    public interface IModeratorService
    {
        Task<PagedResult<RecipeSummaryDTO>> GetAllRecipePendingSubmissionsAsync(int page, int pageSize, string username);
        Task<ModeratorSubmissionResponseDTO> RecipeSubmissionReviewAsync(Guid adminId, Guid recipeId, ModeratorSubmissionReviewDTO recipeReviewDTO);

        Task<PagedResult<PlaylistSummaryDTO>> GetAllPlaylistPendingSubmissionsAsync(int page, int pageSize, string username);
        Task<ModeratorSubmissionResponseDTO> PlaylistSubmissionReviewAsync(Guid adminId, Guid playlistId, ModeratorSubmissionReviewDTO playlistReviewDTO);
    }
}