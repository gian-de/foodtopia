using foodtopia.Database;
using foodtopia.DTOs.Recipe;
using foodtopia.DTOs.Recipe.Submission;
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

            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

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

        public async Task<RecipeSummaryDTO> CreateRecipeAsync(Guid userId, RecipeCreateRequestDTO recipeCreateDTO)
        {
            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            if (recipeCreateDTO is null) throw new ArgumentNullException(nameof(recipeCreateDTO), "Recipe data is required.");

            var country = await _context.Countries.FindAsync(recipeCreateDTO.CountryId);
            if (country is null) throw new ArgumentException($"Country with id {recipeCreateDTO.CountryId} couldn't be found.");

            var recipeModel = recipeCreateDTO.ToRecipeModelFromDTO();
            // attach UserId passed from controller to Model
            recipeModel.UserId = userId;

            _context.Recipes.Add(recipeModel);
            await _context.SaveChangesAsync();

            return recipeModel.ToRecipeSummaryDTO();
        }

        public async Task<RecipeSummaryDTO> UpdateRecipeAsync(Guid userId, Guid recipeId, RecipeUpdateRequestDTO recipeUpdateDTO)
        {
            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            if (recipeUpdateDTO is null) throw new ArgumentNullException(nameof(recipeUpdateDTO), "Recipe data is required.");

            var recipeModel = await _context.Recipes
                                .Include(r => r.Instructions)
                                .Include(r => r.Ingredients)
                                .FirstOrDefaultAsync(r => r.Id == recipeId);

            if (recipeModel is null) throw new KeyNotFoundException($"Recipe with Id {recipeId} was not found.");
            if (recipeModel.UserId != userId) throw new UnauthorizedAccessException("You are not authorized to update this recipe.");

            // Check fields provided in recipeRequest, if true -> update 
            if (!string.IsNullOrWhiteSpace(recipeUpdateDTO.Name))
            {
                recipeModel.Name = recipeUpdateDTO.Name;
            }

            if (recipeUpdateDTO.CountryId.HasValue && recipeUpdateDTO.CountryId.Value != recipeModel.CountryId)
            {
                // check if CountryId exists
                var countryExists = await _context.Countries.AnyAsync(c => c.Id == recipeUpdateDTO.CountryId.Value);

                if (!countryExists) throw new ArgumentException($"Country Id provided does not exist: {recipeUpdateDTO.CountryId.Value}");

                recipeModel.CountryId = recipeUpdateDTO.CountryId.Value;
            }

            if (!string.IsNullOrWhiteSpace(recipeUpdateDTO.ImageUrl))
            {
                recipeModel.ImageUrl = recipeUpdateDTO.ImageUrl;
            }

            if (recipeUpdateDTO.Ingredients != null && recipeUpdateDTO.Ingredients.Any())
            {
                _context.Ingredients.RemoveRange(recipeModel.Ingredients);
                // map requestDTO to recipeModel -> insert to db
                recipeModel.Ingredients = recipeUpdateDTO.Ingredients.Select(ing => new Ingredient
                {
                    Name = ing.Name,
                    Quantity = ing.Quantity,
                    Measurement = ing.Measurement
                }).ToList();
            }

            if (recipeUpdateDTO.Instructions != null && recipeUpdateDTO.Instructions.Count() > 0)
            {
                _context.Instructions.RemoveRange(recipeModel.Instructions);
                // map requestDTO to recipeModel -> insert to db
                recipeModel.Instructions = recipeUpdateDTO.Instructions.Select(ins => new Instruction
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
            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

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

        public async Task<RecipeSubmissionResponseDTO> SubmitRecipeSubmissionAsync(Guid userId, Guid recipeId)
        {
            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            var recipeModel = await _context.Recipes
                                        .Include(r => r.VisibilityReviews)
                                        .FirstOrDefaultAsync(r => r.UserId == userId && r.Id == recipeId);

            if (recipeModel is null) throw new KeyNotFoundException("Recipe not found.");

            recipeModel.VisibilityStatus = "pending";

            // Even though these props are set as default value inside the Model "VisibilityReview", creating a new record allows to have a submission history since the Recipe only stores a reference (collection) 
            var newVisibilityReview = new VisibilityReview
            {
                Id = Guid.NewGuid(),
                VisibilityStatus = "pending",
                SubmittedAt = DateTime.UtcNow,
                RecipeId = recipeModel.Id
            };

            _context.VisibilityReviews.Add(newVisibilityReview);
            await _context.SaveChangesAsync();

            return new RecipeSubmissionResponseDTO(recipeId, "Your recipe has been submitted for review.");
        }

        public async Task<RecipeSubmissionResponseDTO> UnSubmitRecipeSubmissionAsync(Guid userId, Guid recipeId)
        {
            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            var recipeModel = await _context.Recipes
                                        .Include(r => r.VisibilityReviews)
                                        .FirstOrDefaultAsync(r => r.UserId == userId && r.Id == recipeId);

            if (recipeModel is null) throw new KeyNotFoundException("Recipe not found or you are not authorized.");

            var pendingReview = recipeModel.VisibilityReviews.FirstOrDefault(vr => vr.VisibilityStatus == "pending");
            if (pendingReview is null) throw new KeyNotFoundException("This recipe does not have a pending submission to cancel.");

            _context.VisibilityReviews.Remove(pendingReview);
            recipeModel.VisibilityStatus = "private";
            await _context.SaveChangesAsync();

            return new RecipeSubmissionResponseDTO(recipeModel.Id, "Pending submission has been cancelled.");
        }
    }
}