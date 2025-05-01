using foodtopia.DTOs.Recipe;
using foodtopia.DTOs.User;

namespace foodtopia.DTOs.Playlist.Submission
{
    public record PlaylistSubmissionDetailsDTO
    (
        Guid PlaylistId,
        string Name,
        string FullSlug,
        DateTime CreatedAt,
        string VisibilityStatus,
        int HeartedByCount,
        int RecipeCount,
        DateTime? SubmittedAt,
        DateTime? ReviewedAt,
        string? ReviewedByUsername,
        UserTldrDTO User,
        List<RecipeTldrDTO> Recipes
    );
}