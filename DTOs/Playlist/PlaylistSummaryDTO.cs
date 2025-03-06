using foodtopia.DTOs.Recipe;
using foodtopia.DTOs.User;

namespace foodtopia.DTOs.Playlist
{
    public record PlaylistSummaryDTO
    (
        Guid Id,
        string Name,
        string FullSlug,
        DateTime CreatedAt,
        string VisibilityStatus,
        int HeartedByCount,
        UserTldrDTO User,
        List<RecipeTldrDTO>? Recipes
    );
}