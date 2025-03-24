namespace foodtopia.DTOs.Admin.Moderator
{
    public record ModeratorSubmissionResponseDTO
    (
        Guid RecipeId,
        string Message
    );
}