using foodtopia.Database;
using foodtopia.DTOs.Recipe;
using foodtopia.Helpers;
using foodtopia.Interfaces;
using foodtopia.Mappings.Recipes;
using foodtopia.Models;
using Microsoft.EntityFrameworkCore;

namespace foodtopia.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly AppDbContext _context;
        public RecipeService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<PagedResult<RecipeSummaryDTO>> GetAllRecipesAsync(
            int page,
            int pageSize,
            string sortBy,
            string sortDirection)
        {
            if (page < 1 || pageSize < 1) throw new ArgumentException("Page and or Page size must be greater than 0.");

            var isDescending = sortDirection.ToLower() == "desc";

            var query = _context.Recipes
                .Include(r => r.Country)
                .Include(r => r.User)
                .Include(r => r.Ingredients)
                .Include(r => r.Instructions.OrderBy(ins => ins.Order))
                .Include(r => r.Ratings)
                .AsQueryable();

            query = sortBy.ToLower() switch
            {
                "heartedbyusers" => isDescending
                    ? query.OrderByDescending(r => r.HeartedByUsers.Count)
                    : query.OrderBy(r => r.HeartedByUsers.Count),
                "tasteaverage" => isDescending
                    ? query.OrderByDescending(r => r.Ratings.Average(rt => rt.TasteRating))
                    : query.OrderBy(r => r.Ratings.Average(rt => rt.TasteRating)),
                "difficultyaverage" => isDescending
                    ? query.OrderByDescending(r => r.Ratings.Average(rt => rt.DifficultyRating))
                    : query.OrderBy(r => r.Ratings.Average(rt => rt.DifficultyRating)),
                _ => isDescending
                    ? query.OrderByDescending(r => r.PublishedAt)
                    : query.OrderBy(r => r.PublishedAt)
            };


            var totalRecipes = await query.CountAsync();
            var recipesDTOs = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(r => r.ToRecipeSummaryDTO())
                .ToListAsync();

            return new PagedResult<RecipeSummaryDTO>
            {
                TotalCount = totalRecipes,
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalRecipes / (double)pageSize),
                Results = recipesDTOs
            };
        }

        public async Task<RecipeSummaryDTO> GetRecipeByIdAsync(Guid id)
        {
            var recipe = await _context.Recipes
            .Where(r => r.Id == id)
            .Include(r => r.Country)
            .Include(r => r.User)
            .Include(r => r.Ingredients)
            .Include(r => r.Instructions.OrderBy(ins => ins.Order))
            .Include(r => r.Ratings)
            .FirstOrDefaultAsync();

            if (recipe is null) throw new KeyNotFoundException($"Recipe with id {id} was not found.");

            return recipe.ToRecipeSummaryDTO();
        }

        public async Task<RecipeSummaryDTO> CreateRecipeAsync(RecipeCreateRequestDTO recipeRequestDTO)
        {
            if (recipeRequestDTO is null) throw new ArgumentNullException(nameof(recipeRequestDTO), "Recipe data is required.");

            var country = await _context.Countries.FindAsync(recipeRequestDTO.CountryId);
            if (country is null) throw new ArgumentException($"Country with id {recipeRequestDTO.CountryId} couldn't be found.");

            // TODO User auth check

            var recipeModel = recipeRequestDTO.ToRecipeFromCreateDTO();
            _context.Recipes.Add(recipeModel);
            await _context.SaveChangesAsync();

            return recipeModel.ToRecipeSummaryDTO();
        }

        public async Task<RecipeSummaryDTO> UpdateRecipeAsync(Guid id, RecipeUpdateRequestDTO recipeRequest)
        {
            if (recipeRequest is null) throw new ArgumentNullException(nameof(recipeRequest), "Recipe data is required.");

            var recipeModel = await _context.Recipes
                .Include(r => r.Instructions)
                .Include(r => r.Instructions)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (recipeModel is null) throw new KeyNotFoundException($"Recipe with Id {id} was not found.");

            // Check fields provided in recipeRequest, if true -> update 
            if (!string.IsNullOrWhiteSpace(recipeRequest.Name))
            {
                recipeModel.Name = recipeRequest.Name;
            }

            if (recipeRequest.CountryId.HasValue && recipeRequest.CountryId.Value != recipeModel.CountryId)
            {
                // check if CountryId exists
                var countryExists = await _context.Countries.AnyAsync(c => c.Id == recipeRequest.CountryId.Value);

                if (!countryExists) throw new ArgumentException($"Country Id provided does not exist: {recipeRequest.CountryId.Value}");

                recipeModel.CountryId = recipeRequest.CountryId.Value;
            }

            if (!string.IsNullOrWhiteSpace(recipeRequest.ImageUrl))
            {
                recipeModel.ImageUrl = recipeRequest.ImageUrl;
            }

            if (recipeRequest.Ingredients != null && recipeRequest.Ingredients.Any())
            {
                _context.Ingredients.RemoveRange(recipeModel.Ingredients);
                // map requestDTO to recipeModel -> insert to db
                recipeModel.Ingredients = recipeRequest.Ingredients.Select(ing => new Ingredient
                {
                    Name = ing.Name,
                    Quantity = ing.Quantity,
                    Measurement = ing.Measurement
                }).ToList();
            }

            if (recipeRequest.Instructions != null && recipeRequest.Instructions.Count() > 0)
            {
                _context.Instructions.RemoveRange(recipeModel.Instructions);
                // map requestDTO to recipeModel -> insert to db
                recipeModel.Instructions = recipeRequest.Instructions.Select(ins => new Instruction
                {
                    Order = ins.Order,
                    Text = ins.Text
                }).ToList();
            }

            await _context.SaveChangesAsync();

            // refetch the updated Recipe
            var updatedRecipeModel = await _context.Recipes
                .Include(r => r.Country)
                .Include(r => r.User)
                .Include(r => r.Ingredients)
                .Include(r => r.Instructions.OrderBy(ins => ins.Order))
                .Include(r => r.Ratings)
                .FirstOrDefaultAsync(r => r.Id == id);

            // map updated Recipe Model back to DTO
            return updatedRecipeModel?.ToRecipeSummaryDTO();
        }

        public async Task<RecipeDeleteDTO> DeleteRecipeAsync(Guid id)
        {
            var recipeModel = await _context.Recipes
                .Include(r => r.Country)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (recipeModel is null) throw new KeyNotFoundException($"Recipe with ID {id} was not found.");

            _context.Recipes.Remove(recipeModel);
            await _context.SaveChangesAsync();

            return new RecipeDeleteDTO
            (
                recipeModel.Name,
                recipeModel.Country!.Name
            );
        }
    }
}