using foodtopia.DTOs.Recipe;
using foodtopia.Helpers;

namespace foodtopia.Interfaces
{
    public interface IIngredientService
    {
        Task<PagedResult<RecipeSummaryDTO>> SearchRecipesByIngredientsAsync(string[] ingredients, int page, int pageSize);
    }
}