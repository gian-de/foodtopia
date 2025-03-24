namespace foodtopia.DTOs.Admin.Moderator
{
    public record ModeratorSubmissionReviewDTO
    (
        string VisibilityStatus,
        string? ReviewFeedback
    );
}