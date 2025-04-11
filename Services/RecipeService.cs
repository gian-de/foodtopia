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

        public async Task<PagedResult<RecipeSummaryDTO>> GetMyCreatedRecipesAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection, string? visibility = null)
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

            if (!string.IsNullOrEmpty(visibility))
            {
                // "pending", "unlisted", "public", "denied" are the only 4 acceptable params
                recipeQuery = recipeQuery.Where(r => r.VisibilityStatus.ToLower() == visibility.ToLower());
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
                "submittedat" => isDescending
                    // ".ThenBy() is needed in the case of 2 recipes submitted near the same time, the .Then(r.Id) ensures their ordered in a "stable" manner 
                    ? recipeQuery.OrderByDescending(r => r.PublishedAt).ThenByDescending(r => r.Id)
                    : recipeQuery.OrderBy(r => r.PublishedAt).ThenBy(r => r.Id),
                _ => isDescending
                    // ".ThenBy() is needed in the case of 2 recipes submitted near the same time, the .Then(r.Id) ensures their ordered in a "stable" manner
                    ? recipeQuery.OrderByDescending(r => r.PublishedAt).ThenByDescending(r => r.Id)
                    : recipeQuery.OrderBy(r => r.PublishedAt).ThenBy(r => r.Id)
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

        public async Task<PagedResult<RecipeSubmissionDetailsDTO>> GetMyPendingRecipesAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection)
        {
            if (page < 1 || pageSize < 1) throw new ArgumentOutOfRangeException("Page and or page size can not be less than 1.");

            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            bool isDescending = sortDirection.ToLower() == "desc";

            var pendingRecipesQuery = _context.Recipes
                                .Where(r => r.UserId == userId && r.VisibilityReviews.Any(vr => vr.VisibilityStatus == "pending"))
                                .Include(r => r.VisibilityReviews)
                                .Include(r => r.Country)
                                .Include(r => r.Ingredients)
                                .Include(r => r.Instructions.OrderBy(ins => ins.Order))
                                .Include(r => r.Ratings)
                                .AsQueryable();

            pendingRecipesQuery = sortBy.ToLower() switch
            {
                "submittedat" => isDescending
                                    ? pendingRecipesQuery.OrderByDescending(
                                        pr => pr.VisibilityReviews
                                            .Where(vr => vr.VisibilityStatus == "pending")
                                            .Max(vr => vr.SubmittedAt))
                                    : pendingRecipesQuery.OrderBy(
                                        pr => pr.VisibilityReviews
                                            .Where(vr => vr.VisibilityStatus == "pending")
                                            .Min(vr => vr.SubmittedAt)),
                _ => pendingRecipesQuery.OrderByDescending(
                        pr => pr.VisibilityReviews
                                .Where(vr => vr.VisibilityStatus == "pending")
                                .Max(vr => vr.SubmittedAt))
            };

            var totalPendingRecipes = await pendingRecipesQuery.CountAsync();
            var pendingRecipesDTOs = await pendingRecipesQuery
                                    .Skip((page - 1) * pageSize)
                                    .Take(pageSize)
                                    .Select(r => r.ToRecipeSubmissionDetailsDTO("pending"))
                                    .ToListAsync();

            return new PagedResult<RecipeSubmissionDetailsDTO>
            {
                TotalCount = totalPendingRecipes,
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalPendingRecipes / (double)pageSize),
                Results = pendingRecipesDTOs
            };
        }

        public async Task<PagedResult<RecipeSubmissionDetailsDTO>> GetMyApprovedRecipesAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection)
        {
            if (page < 1 || pageSize < 1) throw new ArgumentOutOfRangeException("Page and or page size can not be less than 1.");

            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            bool isDescending = sortDirection.ToLower() == "desc";

            var approvedRecipesQuery = _context.Recipes
                                .Where(r => r.UserId == userId && r.VisibilityReviews.Any(vr => vr.VisibilityStatus == "approved"))
                                .Include(r => r.VisibilityReviews)
                                    .ThenInclude(vr => vr.ReviewedBy)
                                .Include(r => r.Country)
                                .Include(r => r.Ingredients)
                                .Include(r => r.Instructions.OrderBy(ins => ins.Order))
                                .Include(r => r.Ratings)
                                .AsQueryable();

            approvedRecipesQuery = sortBy.ToLower() switch
            {
                "submittedat" => isDescending
                                    ? approvedRecipesQuery.OrderByDescending(
                                        pr => pr.VisibilityReviews
                                            .Where(vr => vr.VisibilityStatus == "approved")
                                            .Max(vr => vr.SubmittedAt))
                                    : approvedRecipesQuery.OrderBy(
                                        pr => pr.VisibilityReviews
                                            .Where(vr => vr.VisibilityStatus == "approved")
                                            .Min(vr => vr.SubmittedAt)),
                _ => approvedRecipesQuery.OrderByDescending(
                        pr => pr.VisibilityReviews
                                .Where(vr => vr.VisibilityStatus == "approved")
                                .Max(vr => vr.SubmittedAt))
            };

            var totalApprovedRecipes = await approvedRecipesQuery.CountAsync();
            var approvedRecipesDTOs = await approvedRecipesQuery
                                    .Skip((page - 1) * pageSize)
                                    .Take(pageSize)
                                    .Select(r => r.ToRecipeSubmissionDetailsDTO("approved"))
                                    .ToListAsync();

            return new PagedResult<RecipeSubmissionDetailsDTO>
            {
                TotalCount = totalApprovedRecipes,
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalApprovedRecipes / (double)pageSize),
                Results = approvedRecipesDTOs
            };
        }

        public async Task<PagedResult<RecipeSubmissionDetailsDTO>> GetMyDeniedRecipesAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection)
        {
            if (page < 1 || pageSize < 1) throw new ArgumentOutOfRangeException("Page and or page size can not be less than 1.");

            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            bool isDescending = sortDirection.ToLower() == "desc";

            var deniedRecipesQuery = _context.Recipes
                                        .Where(r => r.UserId == userId && r.VisibilityStatus.ToLower() == "denied")
                                        .Include(r => r.VisibilityReviews)
                                            .ThenInclude(vr => vr.ReviewedBy)
                                        .Include(r => r.Country)
                                        .Include(r => r.Ingredients)
                                        .Include(r => r.Instructions.OrderBy(ins => ins.Order))
                                        .Include(r => r.Ratings)
                                        .AsQueryable();

            deniedRecipesQuery = sortBy.ToLower() switch
            {
                "submittedat" => isDescending
                                    ? deniedRecipesQuery.OrderByDescending(r => r.VisibilityReviews
                                        .Where(vr => vr.VisibilityStatus.ToLower() == "denied")
                                        .Max(vr => vr.SubmittedAt))
                                    : deniedRecipesQuery.OrderBy(r => r.VisibilityReviews
                                        .Where(vr => vr.VisibilityStatus.ToLower() == "denied")
                                        .Min(vr => vr.SubmittedAt)),
                _ => deniedRecipesQuery.OrderByDescending(r => r.VisibilityReviews
                        .Where(vr => vr.VisibilityStatus.ToLower() == "denied")
                        .Max(vr => vr.SubmittedAt))
            };

            var totalDeniedRecipes = await deniedRecipesQuery.CountAsync();
            var deniedRecipesDTOs = await deniedRecipesQuery
                                    .Skip((page - 1) * pageSize)
                                    .Take(pageSize)
                                    .Select(r => r.ToRecipeSubmissionDetailsDTO("denied"))
                                    .ToListAsync();

            return new PagedResult<RecipeSubmissionDetailsDTO>
            {
                TotalCount = totalDeniedRecipes,
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalDeniedRecipes / (double)pageSize),
                Results = deniedRecipesDTOs
            };
        }

        public async Task<PagedResult<RecipeSubmissionHistoryDTO>> GetRecipeSubmissionHistoryAsync(Guid userId, Guid recipeId, int page, int pageSize)
        {
            if (page < 1 || pageSize < 1) throw new ArgumentOutOfRangeException("Page and or page size can not be less than 1.");

            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            var recipeModel = await _context.Recipes
                                        .Include(r => r.VisibilityReviews)
                                            .ThenInclude(vr => vr.ReviewedBy)
                                        .FirstOrDefaultAsync(r => r.UserId == userId && r.Id == recipeId);
            if (recipeModel is null) throw new UnauthorizedAccessException("Recipe not found.");
            if (recipeModel.UserId != userId) throw new UnauthorizedAccessException("You are not authorized to view this recipe's submission history.");

            var recipeSubmissionHistoryOrdered = recipeModel.VisibilityReviews
                                            .OrderByDescending(vr => vr.SubmittedAt)
                                            .ToList();

            int totalSubmissions = recipeSubmissionHistoryOrdered.Count;

            var recipeSubmissionDTOs = recipeSubmissionHistoryOrdered
                                        .Skip((page - 1) * pageSize)
                                        .Take(pageSize)
                                        .Select(vr => new RecipeSubmissionHistoryDTO(
                                            ReviewId: vr.Id,
                                            VisibilityStatus: vr.VisibilityStatus,
                                            VisibilityFeedback: vr.ReviewFeedback,
                                            SubmittedAt: vr.SubmittedAt,
                                            ReviewedAt: vr.ReviewedAt,
                                            ReviewedByUsername: vr.ReviewedBy?.UserName
                                        ))
                                        .ToList();

            return new PagedResult<RecipeSubmissionHistoryDTO>
            {
                TotalCount = totalSubmissions,
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalSubmissions / (double)pageSize),
                Results = recipeSubmissionDTOs
            };
        }

        public async Task<RecipeSubmissionResponseDTO> SubmitRecipeSubmissionAsync(Guid userId, Guid recipeId)
        {
            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            var recipeModel = await _context.Recipes
                                        .Include(r => r.VisibilityReviews)
                                        .FirstOrDefaultAsync(r => r.UserId == userId && r.Id == recipeId);
            if (recipeModel is null) throw new KeyNotFoundException("Recipe not found.");
            if (recipeModel.UserId != userId) throw new UnauthorizedAccessException("You are not authorized to submit this recipe for submission.");

            var pendingSubmission = recipeModel.VisibilityReviews.FirstOrDefault(vr => vr.VisibilityStatus == "pending");
            if (pendingSubmission is not null) throw new ArgumentException("This recipe already has a pending submission. Unsubmit previous submission in order to submit again.");

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

            if (recipeModel is null) throw new KeyNotFoundException("Recipe not found.");
            if (recipeModel.UserId != userId) throw new UnauthorizedAccessException("You are not authorized to unsubmit this recipe from submission.");

            var pendingReview = recipeModel.VisibilityReviews.FirstOrDefault(vr => vr.VisibilityStatus == "pending");
            if (pendingReview is null) throw new KeyNotFoundException("This recipe does not have a pending submission to cancel.");

            _context.VisibilityReviews.Remove(pendingReview);
            recipeModel.VisibilityStatus = "private";
            await _context.SaveChangesAsync();

            return new RecipeSubmissionResponseDTO(recipeModel.Id, "Pending submission has been cancelled.");
        }
    }
}