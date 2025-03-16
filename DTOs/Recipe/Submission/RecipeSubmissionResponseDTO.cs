namespace foodtopia.DTOs.Recipe.Submission
{
    public record RecipeSubmissionResponseDTO
    (
        Guid RecipeId,
        string Message
    );
}