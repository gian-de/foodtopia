namespace foodtopia.DTOs.Ingredient
{
    public record IngredientDTO
    (
        Guid Id,
        string Name,
        decimal Quantity,
        string? Measurement
    );
}