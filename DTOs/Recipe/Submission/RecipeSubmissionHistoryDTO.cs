namespace foodtopia.DTOs.Recipe.Submission
{
    public record RecipeSubmissionHistoryDTO
    (
        Guid ReviewId,
        string VisibilityStatus,
        string? VisibilityFeedback,
        DateTime SubmittedAt,
        DateTime? ReviewedAt,
        string? ReviewedByUsername
    );
}