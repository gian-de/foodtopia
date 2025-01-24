namespace foodtopia.DTOs.Ingredient
{
    public record IngredientCreateDTO
    (
        string Name,
        decimal Quantity,
        string? Measurement
    );
}