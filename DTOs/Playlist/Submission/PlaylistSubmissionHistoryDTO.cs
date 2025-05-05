namespace foodtopia.DTOs.Playlist.Submission
{
    public record PlaylistSubmissionHistoryDTO
    (
        Guid ReviewId,
        string VisibilityStatus,
        string? VisibilityFeedback,
        DateTime SubmittedAt,
        DateTime? ReviewedAt,
        string? ReviewedByUsername
    );
}