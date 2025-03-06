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
        int RecipeCount,
        UserTldrDTO User,
        List<RecipeTldrDTO>? Recipes
    );
}