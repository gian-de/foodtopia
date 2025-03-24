using foodtopia.DTOs.Admin.Moderator;
using foodtopia.DTOs.Recipe;
using foodtopia.Helpers;

namespace foodtopia.Interfaces.Admin
{
    public interface IModeratorService
    {
        Task<PagedResult<RecipeSummaryDTO>> GetAllRecipePendingSubmissionsAsync(int page, int pageSize, string username);
        Task<ModeratorSubmissionResponseDTO> RecipeSubmissionReviewAsync(Guid adminId, Guid recipeId, ModeratorSubmissionReviewDTO reviewDTO);
    }
}