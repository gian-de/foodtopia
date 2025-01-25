namespace foodtopia.DTOs.Ingredient
{
    public record IngredientUpdateDTO
    (
        string Name,
        decimal Quantity,
        string? Measurement
    );
}