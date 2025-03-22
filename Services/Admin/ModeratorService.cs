using foodtopia.Database;
using foodtopia.DTOs.Recipe;
using foodtopia.Helpers;
using foodtopia.Interfaces.Admin;
using foodtopia.Mappings.Recipes;
using Microsoft.EntityFrameworkCore;

namespace foodtopia.Services.Admin
{
    public class ModeratorService : IModeratorService
    {
        private readonly AppDbContext _context;
        public ModeratorService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<PagedResult<RecipeSummaryDTO>> GetAllRecipePendingSubmissionsAsync(int page, int pageSize, string username)
        {
            if (page < 1 || pageSize < 1) throw new ArgumentOutOfRangeException("Page and or page size can not be less than 1");

            if (!string.IsNullOrEmpty(username))
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName.ToLower() == username.ToLower());
                if (user is null) throw new KeyNotFoundException($"User with the username: '{username}' not found.");
            }

            var pendingRecipeSubmissions = _context.VisibilityReviews
                                                    .Where(vr => vr.VisibilityStatus == "pending" && vr.RecipeId != null) // "&& vr.RecipeId != null" explicitly added since we only want the Recipes submitted and not any Playlists since they're both saved to the 'VisibilityReviews' model/ dbset
                                                    .Include(vr => vr.Recipe)
                                                        .ThenInclude(r => r.User)
                                                    .Include(vr => vr.Recipe)
                                                        .ThenInclude(r => r.Country)
                                                    .Include(vr => vr.Recipe)
                                                        .ThenInclude(r => r.Ingredients)
                                                    .Include(vr => vr.Recipe)
                                                        .ThenInclude(r => r.Instructions)
                                                    .Include(vr => vr.Recipe)
                                                        .ThenInclude(r => r.Ratings)
                                                    .OrderBy(vr => vr.SubmittedAt)
                                                    .Select(vr => vr.Recipe)
                                                    .AsQueryable();

            int totalPendingRecipes = await pendingRecipeSubmissions.CountAsync();

            var pendingRecipesDTOs = await pendingRecipeSubmissions
                                        .Skip((page - 1) * pageSize)
                                        .Take(pageSize)
                                        .Select(pr => pr.ToRecipeSummaryDTO())
                                        .ToListAsync();

            return new PagedResult<RecipeSummaryDTO>
            {
                TotalCount = totalPendingRecipes,
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling((double)totalPendingRecipes / pageSize),
                Results = pendingRecipesDTOs
            };
        }
    }
}