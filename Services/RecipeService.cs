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
            string sortDirection,
            string? username = null)
        {
            if (page < 1 || pageSize < 1) throw new ArgumentException("Page and or Page size must be greater than 0.");

            bool isDescending = sortDirection.ToLower() == "desc";

            if (!string.IsNullOrEmpty(username))
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName.ToLower() == username.ToLower());
                if (user is null) throw new KeyNotFoundException($"User with the username: '{username}' not found.");
            }

            IQueryable<Recipe> recipeQuery = _context.Recipes
                                .Include(r => r.Country)
                                .Include(r => r.User)
                                .Include(r => r.Ingredients)
                                .Include(r => r.Instructions.OrderBy(ins => ins.Order))
                                .Include(r => r.Ratings)
                                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(username))
            {
                recipeQuery = recipeQuery.Where(r => r.User.UserName.ToLower() == username.ToLower());
            }

            recipeQuery = sortBy.ToLower() switch
            {
                "heartedbyusers" => isDescending
                    ? recipeQuery.OrderByDescending(r => r.HeartedByUsers.Count)
                    : recipeQuery.OrderBy(r => r.HeartedByUsers.Count),
                "tasteaverage" => isDescending
                    ? recipeQuery.OrderByDescending(r => r.Ratings.Average(rt => rt.TasteRating))
                    : recipeQuery.OrderBy(r => r.Ratings.Average(rt => rt.TasteRating)),
                "difficultyaverage" => isDescending
                    ? recipeQuery.OrderByDescending(r => r.Ratings.Average(rt => rt.DifficultyRating))
                    : recipeQuery.OrderBy(r => r.Ratings.Average(rt => rt.DifficultyRating)),
                _ => isDescending
                    ? recipeQuery.OrderByDescending(r => r.PublishedAt)
                    : recipeQuery.OrderBy(r => r.PublishedAt)
            };


            var totalRecipes = await recipeQuery.CountAsync();
            var recipesDTOs = await recipeQuery
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

        public async Task<RecipeSummaryDTO> GetRecipeByIdAsync(Guid recipeId)
        {
            var recipe = await _context.Recipes
                                .Where(r => r.Id == recipeId)
                                .Include(r => r.Country)
                                .Include(r => r.User)
                                .Include(r => r.Ingredients)
                                .Include(r => r.Instructions.OrderBy(ins => ins.Order))
                                .Include(r => r.Ratings)
                                .FirstOrDefaultAsync();

            if (recipe is null) throw new KeyNotFoundException($"Recipe with id {recipeId} was not found.");

            return recipe.ToRecipeSummaryDTO();
        }

        public async Task<PagedResult<RecipeSummaryDTO>> GetMyCreatedRecipesAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection)
        {
            if (page < 1 || pageSize < 1) throw new ArgumentException("Page and or Page size must be greater than 0.");

            var userCheck = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (userCheck is null) throw new KeyNotFoundException("User that was passed to query was not found.");

            bool isDescending = sortDirection.ToLower() == "desc";

            var recipeQuery = _context.Recipes
                                .Where(r => r.UserId == userId)
                                .Include(r => r.Country)
                                .Include(r => r.User)
                                .Include(r => r.Ingredients)
                                .Include(r => r.Instructions.OrderBy(ins => ins.Order))
                                .Include(r => r.Ratings)
                                .AsQueryable();

            recipeQuery = sortBy.ToLower() switch
            {
                "heartedbyusers" => isDescending
                    ? recipeQuery.OrderByDescending(r => r.HeartedByUsers.Count)
                    : recipeQuery.OrderBy(r => r.HeartedByUsers.Count),
                "tasteaverage" => isDescending
                    ? recipeQuery.OrderByDescending(r => r.Ratings.Average(rt => rt.TasteRating))
                    : recipeQuery.OrderBy(r => r.Ratings.Average(rt => rt.TasteRating)),
                "difficultyaverage" => isDescending
                    ? recipeQuery.OrderByDescending(r => r.Ratings.Average(rt => rt.DifficultyRating))
                    : recipeQuery.OrderBy(r => r.Ratings.Average(rt => rt.DifficultyRating)),
                _ => isDescending
                    ? recipeQuery.OrderByDescending(r => r.PublishedAt)
                    : recipeQuery.OrderBy(r => r.PublishedAt)
            };


            var totalRecipes = await recipeQuery.CountAsync();
            var recipesDTOs = await recipeQuery
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .Select(r => r.ToRecipeSummaryDTO())
                                .ToListAsync();

            return new PagedResult<RecipeSummaryDTO>
            {
                TotalCount = totalRecipes,
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling((double)totalRecipes / pageSize),
                Results = recipesDTOs
            };
        }

        public async Task<RecipeSummaryDTO> CreateRecipeAsync(Guid userId, RecipeCreateRequestDTO recipeRequestDTO)
        {
            var userCheck = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (userCheck is null) throw new KeyNotFoundException("User that was passed to query was not found.");

            if (recipeRequestDTO is null) throw new ArgumentNullException(nameof(recipeRequestDTO), "Recipe data is required.");

            var country = await _context.Countries.FindAsync(recipeRequestDTO.CountryId);
            if (country is null) throw new ArgumentException($"Country with id {recipeRequestDTO.CountryId} couldn't be found.");

            var recipeModel = recipeRequestDTO.ToRecipeFromCreateDTO();
            // attach UserId passed from controller to Model
            recipeModel.UserId = userId;

            _context.Recipes.Add(recipeModel);
            await _context.SaveChangesAsync();

            return recipeModel.ToRecipeSummaryDTO();
        }

        public async Task<RecipeSummaryDTO> UpdateRecipeAsync(Guid userId, Guid recipeId, RecipeUpdateRequestDTO recipeRequest)
        {
            var userCheck = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (userCheck is null) throw new KeyNotFoundException("User that was passed to query was not found.");

            if (recipeRequest is null) throw new ArgumentNullException(nameof(recipeRequest), "Recipe data is required.");

            var recipeModel = await _context.Recipes
                                .Include(r => r.Instructions)
                                .Include(r => r.Ingredients)
                                .FirstOrDefaultAsync(r => r.Id == recipeId);

            if (recipeModel is null) throw new KeyNotFoundException($"Recipe with Id {recipeId} was not found.");
            if (recipeModel.UserId != userId) throw new UnauthorizedAccessException("You are not authorized to delete this recipe.");

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
                                        .FirstOrDefaultAsync(r => r.Id == recipeId);

            // map updated Recipe Model back to DTO
            return updatedRecipeModel?.ToRecipeSummaryDTO();
        }

        public async Task<RecipeDeleteDTO> DeleteRecipeAsync(Guid userId, Guid recipeId)
        {
            var userCheck = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (userCheck is null) throw new KeyNotFoundException("User that was passed to query was not found.");

            var recipeModel = await _context.Recipes
                                .Include(r => r.Country)
                                .FirstOrDefaultAsync(r => r.Id == recipeId);

            if (recipeModel is null) throw new KeyNotFoundException($"Recipe with ID {recipeId} was not found.");
            if (recipeModel.UserId != userId) throw new UnauthorizedAccessException("You are not authorized to delete this recipe.");

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