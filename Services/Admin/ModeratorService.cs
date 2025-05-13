using foodtopia.Database;
using foodtopia.DTOs.Admin.Moderator;
using foodtopia.DTOs.Playlist;
using foodtopia.DTOs.Recipe;
using foodtopia.Helpers;
using foodtopia.Interfaces.Admin;
using foodtopia.Mappings.Playlists;
using foodtopia.Mappings.Recipes;
using foodtopia.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace foodtopia.Services.Admin
{
    public class ModeratorService : IModeratorService
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public ModeratorService(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<PagedResult<RecipeSummaryDTO>> GetAllRecipePendingSubmissionsAsync(int page, int pageSize, string? username)
        {
            if (page < 1 || pageSize < 1) throw new ArgumentOutOfRangeException("Page and or page size can not be less than 1");

            if (!string.IsNullOrEmpty(username))
            {
                var user = await _context.Users
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(u => u.UserName != null && u.UserName.ToLower() == username.ToLower());
                if (user is null) throw new KeyNotFoundException($"User with the username: '{username}' not found.");
            }

            // var pendingRecipeSubmissions = _context.VisibilityReviews
            //                                         .Where(vr => vr.VisibilityStatus == "pending" && vr.RecipeId != null) // "&& vr.RecipeId != null" explicitly added since we only want the Recipes submitted and not any Playlists since they're both saved to the 'VisibilityReviews' model/ dbset
            //                                         .Include(vr => vr.Recipe)
            //                                             .ThenInclude(r => r.User!)
            //                                         .Include(vr => vr.Recipe)
            //                                             .ThenInclude(r => r.Country!)
            //                                         .Include(vr => vr.Recipe)
            //                                             .ThenInclude(r => r.Ingredients!)
            //                                         .Include(vr => vr.Recipe)
            //                                             .ThenInclude(r => r.Instructions!)
            //                                         .Include(vr => vr.Recipe)
            //                                             .ThenInclude(r => r.Ratings!)
            //                                         .OrderBy(vr => vr.SubmittedAt)
            //                                         .Select(vr => vr.Recipe)
            //                                         .AsQueryable();

            var pendingRecipeSubmissions = _context.VisibilityReviews
                                                    .Where(vr => vr.VisibilityStatus == "pending" && vr.RecipeId != null) // "&& vr.RecipeId != null" explicitly added since we only want the Recipes submitted and not any Playlists since they're both saved to the 'VisibilityReviews' model/ dbset
                                                    .OrderBy(vr => vr.SubmittedAt)
                                                    .Include(vr => vr.Recipe!)
                                                        .ThenInclude(r => r.User)
                                                    .Include(vr => vr.Recipe!)
                                                        .ThenInclude(r => r.Country)
                                                    .Include(vr => vr.Recipe!)
                                                        .ThenInclude(r => r.Ingredients)
                                                    .Include(vr => vr.Recipe!)
                                                        .ThenInclude(r => r.Instructions.OrderBy(ins => ins.Order))
                                                    .Include(vr => vr.Recipe!)
                                                        .ThenInclude(r => r.Ratings)
                                                    .Select(vr => vr.Recipe!)
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

        public async Task<ModeratorSubmissionResponseDTO> RecipeSubmissionReviewAsync(Guid adminId, Guid recipeId, ModeratorSubmissionReviewDTO recipeReviewDTO)
        {
            var newVisibilityStatus = recipeReviewDTO.VisibilityStatus.ToLower();
            if (newVisibilityStatus != "approved" && newVisibilityStatus != "denied") throw new ArgumentException("Visibility status must be either 'approved' or 'denied'.");

            // verify Admin exists and create new var adminUser to pass into .GetRolesAsync() <- since that method requires an 'AppUser' as an argument and you can pass the 'Guid adminId'.
            var adminUser = await _userManager.FindByIdAsync(adminId.ToString());
            if (adminUser is null) throw new UnauthorizedAccessException("Admin passed in was not found.");

            var adminRoles = await _userManager.GetRolesAsync(adminUser);
            if (!adminRoles.Contains("Senior Admin") && !adminRoles.Contains("Admin"))
                throw new UnauthorizedAccessException("User is not authorized to review submissions.");

            // load recipe to then pass into/update VisibilityReviews foreign table helps data integrity that whats being updated in the VisibilityReviews table is linked to an active Recipe
            var recipeModel = await _context.Recipes
                                                .Include(r => r.VisibilityReviews)
                                                .FirstOrDefaultAsync(r => r.Id == recipeId);
            if (recipeModel is null) throw new KeyNotFoundException("Recipe passed in was not found.");

            var pendingRecipeSubmission = recipeModel.VisibilityReviews.FirstOrDefault(vr => vr.VisibilityStatus == "pending");
            if (pendingRecipeSubmission is null)
            {
                if (recipeModel.VisibilityReviews.Any(vr => vr.VisibilityStatus.ToLower() == "denied")) throw new ArgumentException("Unable to edit a 'denied' recipe to 'approved'. User must resubmit their submission for review again.");
                throw new ArgumentNullException("Recipe has no 'pending' submissions.");
            }

            if (newVisibilityStatus == "denied")
            {
                if (string.IsNullOrWhiteSpace(recipeReviewDTO.ReviewFeedback)) throw new ArgumentException("Review feedback is required when denying a submission.");
                pendingRecipeSubmission.VisibilityStatus = "denied";
                pendingRecipeSubmission.ReviewFeedback = recipeReviewDTO.ReviewFeedback;
                recipeModel.VisibilityStatus = "denied";
            }
            else if (newVisibilityStatus == "approved")
            {
                pendingRecipeSubmission.VisibilityStatus = "approved";
                pendingRecipeSubmission.ReviewFeedback = null;
                recipeModel.VisibilityStatus = "public";
            }

            pendingRecipeSubmission.ReviewedAt = DateTime.UtcNow;
            pendingRecipeSubmission.ReviewedById = adminId;

            await _context.SaveChangesAsync();

            return new ModeratorSubmissionResponseDTO(recipeId, "Your review has been posted successfully.");
        }

        public async Task<PagedResult<PlaylistSummaryDTO>> GetAllPlaylistPendingSubmissionsAsync(int page, int pageSize, string? username)
        {
            if (page < 1 || pageSize < 1) throw new ArgumentOutOfRangeException("Page and or page size can not be less than 1");

            if (!string.IsNullOrEmpty(username))
            {
                var user = await _context.Users
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(u => u.UserName != null && u.UserName.ToLower() == username.ToLower());
                if (user is null) throw new KeyNotFoundException($"User with the username: '{username}' not found.");
            }

            // var pendingPlaylistSubmissions = _context.VisibilityReviews
            //                                         .Where(vr => vr.VisibilityStatus == "pending" && vr.PlaylistId != null) // "&& vr.PlaylistId != null" explicitly added since we only want the Playlists submitted and not any Recipes since they're both saved to the 'VisibilityReviews' model/ dbset
            //                                         .Include(vr => vr.Playlist)
            //                                             .ThenInclude(p => p.User)
            //                                         .Include(vr => vr.Playlist)
            //                                             .ThenInclude(p => p.HeartedByUsers)
            //                                         .Include(vr => vr.Playlist)
            //                                             .ThenInclude(p => p.PlaylistRecipes)
            //                                                 .ThenInclude(pr => pr.Recipe)
            //                                                     .ThenInclude(r => r.Country)
            //                                         .Include(vr => vr.Playlist)
            //                                             .ThenInclude(p => p.PlaylistRecipes)
            //                                                 .ThenInclude(pr => pr.Recipe)
            //                                                     .ThenInclude(r => r.Ratings)
            //                                         .Include(vr => vr.Playlist)
            //                                             .ThenInclude(p => p.PlaylistRecipes)
            //                                                 .ThenInclude(pr => pr.Recipe)
            //                                                     .ThenInclude(r => r.User)
            //                                         .OrderBy(vr => vr.SubmittedAt)
            //                                         .Select(vr => vr.Playlist)
            //                                         .AsQueryable();
            var pendingPlaylistSubmissions = _context.VisibilityReviews
                                                    .Where(vr => vr.VisibilityStatus == "pending" && vr.PlaylistId != null) // "&& vr.PlaylistId != null" explicitly added since we only want the Playlists submitted and not any Recipes since they're both saved to the 'VisibilityReviews' model/ dbset
                                                    .OrderBy(vr => vr.SubmittedAt)
                                                    .Include(vr => vr.Playlist!)
                                                        .ThenInclude(p => p.User)
                                                    .Include(vr => vr.Playlist!)
                                                        .ThenInclude(p => p.HeartedByUsers)
                                                    .Include(vr => vr.Playlist!)
                                                        .ThenInclude(p => p.PlaylistRecipes)
                                                                .ThenInclude(pr => pr.Recipe)
                                                                    .ThenInclude(r => r.Country)
                                                    .Include(vr => vr.Playlist!)
                                                        .ThenInclude(p => p.PlaylistRecipes)
                                                            .ThenInclude(pr => pr.Recipe)
                                                                .ThenInclude(r => r.Ratings)
                                                    .Include(vr => vr.Playlist!)
                                                        .ThenInclude(p => p.PlaylistRecipes)
                                                            .ThenInclude(pr => pr.Recipe)
                                                                .ThenInclude(r => r.User)
                                                    .Select(vr => vr.Playlist!)
                                                    .AsQueryable();

            int totalPendingPlaylists = await pendingPlaylistSubmissions.CountAsync();

            var pendingPlaylistsDTOs = await pendingPlaylistSubmissions
                                        .Skip((page - 1) * pageSize)
                                        .Take(pageSize)
                                        .Select(p => p.ToPlaylistSummaryDTO())
                                        .ToListAsync();

            return new PagedResult<PlaylistSummaryDTO>
            {
                TotalCount = totalPendingPlaylists,
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling((double)totalPendingPlaylists / pageSize),
                Results = pendingPlaylistsDTOs
            };
        }

        public async Task<ModeratorSubmissionResponseDTO> PlaylistSubmissionReviewAsync(Guid adminId, Guid playlistId, ModeratorSubmissionReviewDTO playlistReviewDTO)
        {
            var newVisibilityStatus = playlistReviewDTO.VisibilityStatus.ToLower();
            if (newVisibilityStatus != "approved" && newVisibilityStatus != "denied") throw new ArgumentException("Visibility status must be either 'approved' or 'denied'.");

            // verify Admin exists and create new var adminUser to pass into .GetRolesAsync() <- since that method requires an 'AppUser' as an argument and you can pass the 'Guid adminId'.
            var adminUser = await _userManager.FindByIdAsync(adminId.ToString());
            if (adminUser is null) throw new UnauthorizedAccessException("Admin passed in was not found.");

            var adminRoles = await _userManager.GetRolesAsync(adminUser);
            if (!adminRoles.Contains("Senior Admin") && !adminRoles.Contains("Admin"))
                throw new UnauthorizedAccessException("User is not authorized to review submissions.");

            // load recipe to then pass into/update VisibilityReviews foreign table helps data integrity that whats being updated in the VisibilityReviews table is linked to an active Recipe
            var playlistModel = await _context.Playlists
                                                .Include(r => r.VisibilityReviews)
                                                .FirstOrDefaultAsync(r => r.Id == playlistId);
            if (playlistModel is null) throw new KeyNotFoundException("Playlist passed in was not found.");

            var pendingPlaylistSubmission = playlistModel.VisibilityReviews.FirstOrDefault(vr => vr.VisibilityStatus == "pending");
            if (pendingPlaylistSubmission is null)
            {
                if (playlistModel.VisibilityReviews.Any(vr => vr.VisibilityStatus.ToLower() == "denied")) throw new ArgumentException("Unable to edit a 'denied' playlist to 'approved'. User must resubmit their submission for review again.");
                throw new ArgumentNullException("Playlist has no 'pending' submissions.");
            }

            if (newVisibilityStatus == "denied")
            {
                if (string.IsNullOrWhiteSpace(playlistReviewDTO.ReviewFeedback)) throw new ArgumentException("Review feedback is required when denying a submission.");
                pendingPlaylistSubmission.VisibilityStatus = "denied";
                pendingPlaylistSubmission.ReviewFeedback = playlistReviewDTO.ReviewFeedback;
                playlistModel.VisibilityStatus = "denied";
            }
            else if (newVisibilityStatus == "approved")
            {
                pendingPlaylistSubmission.VisibilityStatus = "approved";
                pendingPlaylistSubmission.ReviewFeedback = null;
                playlistModel.VisibilityStatus = "public";
            }

            pendingPlaylistSubmission.ReviewedAt = DateTime.UtcNow;
            pendingPlaylistSubmission.ReviewedById = adminId;

            await _context.SaveChangesAsync();

            return new ModeratorSubmissionResponseDTO(playlistId, "Your review has been posted successfully.");
        }
    }
}