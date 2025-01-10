namespace foodtopia.DTOs.Rating
{
    public record RatingDTO
    (
        Guid Id,
        decimal TasteRating,
        decimal DifficultyRating
    );
}