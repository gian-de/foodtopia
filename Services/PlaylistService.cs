using foodtopia.Database;
using foodtopia.DTOs.Playlist;
using foodtopia.DTOs.Playlist.Submission;
using foodtopia.Helpers;
using foodtopia.Interfaces;
using foodtopia.Mappings.Playlists;
using foodtopia.Models;
using Microsoft.EntityFrameworkCore;

namespace foodtopia.Services
{
    public class PlaylistService : IPlaylistService
    {
        private readonly AppDbContext _context;
        public PlaylistService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<PlaylistSummaryDTO>> GetAllPlaylistsAsync(int page, int pageSize, string sortBy, string sortDirection)
        {
            if (page < 1 || pageSize < 1) throw new ArgumentException("Page and or Page size must be greater than 0.");

            bool isDescending = sortDirection.ToLower() == "desc";

            var playlistQuery = _context.Playlists
                                    .Where(p => p.VisibilityStatus == "public")
                                    .Include(p => p.User)
                                    .Include(p => p.HeartedByUsers)
                                    .Include(p => p.PlaylistRecipes)
                                        .ThenInclude(pr => pr.Recipe)
                                            .ThenInclude(r => r.HeartedByUsers) // to have the .Count or hearts for each Recipe
                                    .Include(p => p.PlaylistRecipes)
                                        .ThenInclude(pr => pr.Recipe)
                                            .ThenInclude(r => r.User) // to show Username in RecipeTldrDTO
                                    .Include(p => p.PlaylistRecipes)
                                        .ThenInclude(pr => pr.Recipe)
                                            .ThenInclude(r => r.Ratings)
                                    .Include(p => p.PlaylistRecipes)
                                        .ThenInclude(pr => pr.Recipe)
                                            .ThenInclude(r => r.Country)
                                    .AsQueryable();

            playlistQuery = sortBy.ToLower() switch
            {
                "createdat" => isDescending
                    ? playlistQuery.OrderByDescending(p => p.CreatedAt)
                    : playlistQuery.OrderBy(p => p.CreatedAt),
                "heartedbycount" => isDescending
                    ? playlistQuery.OrderByDescending(p => p.HeartedByUsers.Count)
                    : playlistQuery.OrderBy(p => p.HeartedByUsers.Count),
                _ => playlistQuery.OrderByDescending(p => p.HeartedByUsers.Count)
            };

            int totalPlaylists = await playlistQuery.CountAsync();
            var playlistDTOs = await playlistQuery
                                        .Skip((page - 1) * pageSize)
                                        .Take(pageSize)
                                        .Select(p => p.ToPlaylistSummaryDTO())
                                        .ToListAsync();

            return new PagedResult<PlaylistSummaryDTO>
            {
                TotalCount = totalPlaylists,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling((double)totalPlaylists / pageSize),
                Results = playlistDTOs
            };
        }

        public async Task<PlaylistSummaryDTO> GetPlaylistByFullSlugAsync(string fullSlug)
        {
            var playlistQuery = await _context.Playlists
                                    .Where(p => p.FullSlug == fullSlug)
                                    .Include(p => p.User)
                                    .Include(p => p.HeartedByUsers)
                                    .Include(p => p.PlaylistRecipes)
                                        .ThenInclude(pr => pr.Recipe)
                                            .ThenInclude(r => r.HeartedByUsers)
                                    .Include(p => p.PlaylistRecipes)
                                        .ThenInclude(pr => pr.Recipe)
                                            .ThenInclude(r => r.User)
                                    .Include(p => p.PlaylistRecipes)
                                        .ThenInclude(pr => pr.Recipe)
                                            .ThenInclude(r => r.Ratings)
                                    .Include(p => p.PlaylistRecipes)
                                        .ThenInclude(pr => pr.Recipe)
                                            .ThenInclude(r => r.Country)
                                    .FirstOrDefaultAsync();

            if (playlistQuery is null) throw new KeyNotFoundException($"Playlist with full slug {fullSlug} was not found.");
            return playlistQuery.ToPlaylistSummaryDTO();
        }

        public async Task<PagedResult<PlaylistSummaryDTO>> GetMyCreatedPlaylistsAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection)
        {
            if (page < 1 || pageSize < 1) throw new ArgumentException("Page and or Page size must be greater than 0.");
            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            bool isDescending = sortDirection.ToLower() == "desc";

            var playlistQuery = _context.Playlists
                                    .Where(p => p.UserId == userId)
                                    .Include(p => p.User)
                                    .Include(p => p.HeartedByUsers) // Include to .Count how many users for orderBy functionality
                                    .Include(p => p.PlaylistRecipes)
                                        .ThenInclude(pr => pr.Recipe) // Include Recipe details
                                            .ThenInclude(r => r.HeartedByUsers) // to use Recipe HeartCount in RecipeTldrDTO
                                    .Include(p => p.PlaylistRecipes)
                                        .ThenInclude(pr => pr.Recipe)
                                            .ThenInclude(r => r.User) // to show Username in RecipeTldrDTO
                                    .Include(p => p.PlaylistRecipes)
                                        .ThenInclude(pr => pr.Recipe)
                                            .ThenInclude(r => r.Ratings)
                                    .Include(p => p.PlaylistRecipes)
                                        .ThenInclude(pr => pr.Recipe)
                                            .ThenInclude(r => r.Country)
                                    .AsQueryable();

            playlistQuery = sortBy.ToLower() switch
            {
                "createdat" => isDescending
                    ? playlistQuery.OrderByDescending(p => p.CreatedAt)
                    : playlistQuery.OrderBy(p => p.CreatedAt),
                "heartedbycount" => isDescending
                    ? playlistQuery.OrderByDescending(p => p.HeartedByUsers.Count)
                    : playlistQuery.OrderBy(p => p.HeartedByUsers.Count),
                _ => playlistQuery.OrderByDescending(p => p.CreatedAt)
            };

            int totalPlaylists = await playlistQuery.CountAsync();
            var playlistDTOs = await playlistQuery
                                    .Skip((page - 1) * pageSize)
                                    .Take(pageSize)
                                    .Select(p => p.ToPlaylistSummaryDTO())
                                    .ToListAsync();

            return new PagedResult<PlaylistSummaryDTO>
            {
                TotalCount = totalPlaylists,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling((double)totalPlaylists / pageSize),
                Results = playlistDTOs
            };
        }

        public async Task<PlaylistSummaryDTO> CreatePlaylistAsync(Guid userId, PlaylistCreateRequestDTO playlistCreateDTO)
        {
            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            if (playlistCreateDTO is null) throw new ArgumentNullException(nameof(playlistCreateDTO), "Playlist data is required.");
            if (string.IsNullOrWhiteSpace(playlistCreateDTO.Name)) throw new ArgumentException("Playlist name is required and cannot be empty.");
            if (string.IsNullOrWhiteSpace(playlistCreateDTO.SlugText)) throw new ArgumentException("Slug text is required and cannot be empty.");
            if (!playlistCreateDTO.SlugNumber.HasValue) throw new ArgumentException("Slug number is required.");

            string fullSlug = $"{playlistCreateDTO.SlugText.Replace(" ", "_").ToLower()}-{playlistCreateDTO.SlugNumber}";
            bool fullSlugExists = await _context.Playlists.AnyAsync(p => p.FullSlug == fullSlug);
            if (fullSlugExists) throw new ArgumentException("A playlist with this slug already exists.");

            var playlistModelCreated = playlistCreateDTO.ToPlaylistModelFromDTO();
            playlistModelCreated.UserId = userId;
            playlistModelCreated.FullSlug = fullSlug;

            _context.Playlists.Add(playlistModelCreated);
            await _context.SaveChangesAsync();

            var playlistModel = await _context.Playlists
                                        .Include(p => p.User)
                                        .Include(p => p.HeartedByUsers)
                                        .Include(p => p.PlaylistRecipes)
                                            .ThenInclude(pr => pr.Recipe)
                                        // .ThenInclude(r => r.User)
                                        .Include(p => p.PlaylistRecipes)
                                            .ThenInclude(pr => pr.Recipe)
                                                .ThenInclude(r => r.Country)
                                        .Include(p => p.PlaylistRecipes)
                                            .ThenInclude(pr => pr.Recipe)
                                                .ThenInclude(r => r.Ratings)
                                        .Include(p => p.PlaylistRecipes)
                                            .ThenInclude(pr => pr.Recipe)
                                                .ThenInclude(r => r.HeartedByUsers)
                                        .FirstAsync(p => p.Id == playlistModelCreated.Id);

            return playlistModel.ToPlaylistSummaryDTO();
        }

        public async Task<PlaylistSummaryDTO> UpdatePlaylistAsync(Guid userId, Guid playlistId, PlaylistUpdateRequestDTO playlistUpdateDTO)
        {
            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            if (playlistUpdateDTO is null) throw new ArgumentNullException("Playlist data sent cannot be empty.");

            var playlistModel = await _context.Playlists
                                        .Include(p => p.User)
                                        .Include(p => p.PlaylistRecipes)
                                            .ThenInclude(pr => pr.Recipe)
                                                .ThenInclude(r => r.User)
                                        .Include(p => p.PlaylistRecipes)
                                            .ThenInclude(pr => pr.Recipe)
                                                .ThenInclude(r => r.Country)
                                        .Include(p => p.PlaylistRecipes)
                                            .ThenInclude(pr => pr.Recipe)
                                                .ThenInclude(r => r.Ratings)
                                        .Include(p => p.PlaylistRecipes)
                                            .ThenInclude(pr => pr.Recipe)
                                                .ThenInclude(r => r.HeartedByUsers)
                                        .FirstOrDefaultAsync(p => p.Id == playlistId);

            if (playlistModel is null) throw new KeyNotFoundException("The playlist you wanted to update doesn't exist.");

            if (playlistModel.UserId != userId) throw new UnauthorizedAccessException("Only the original creator of the playlist can update.");

            bool slugChanged = false;

            if (!string.IsNullOrWhiteSpace(playlistUpdateDTO.Name))
            {
                playlistModel.Name = playlistUpdateDTO.Name;
            }

            if (!string.IsNullOrWhiteSpace(playlistUpdateDTO.SlugText))
            {
                playlistModel.SlugText = playlistUpdateDTO.SlugText;
                slugChanged = true;
            }

            if (playlistUpdateDTO.SlugNumber > 0 && playlistUpdateDTO.SlugNumber < 9999)
            {
                playlistModel.SlugNumber = playlistUpdateDTO.SlugNumber.Value;
                slugChanged = true;
            }

            if (slugChanged)
            {
                string newFullSlug = $"{playlistModel.SlugText.Replace(" ", "_").ToLower()}-{playlistModel.SlugNumber}";

                bool slugExists = await _context.Playlists.AnyAsync(p => p.FullSlug == newFullSlug && p.Id != playlistId);

                if (slugExists) throw new ArgumentException("A playlist with this slug already exists.");

                playlistModel.FullSlug = newFullSlug;
            }

            await _context.SaveChangesAsync();
            return playlistModel.ToPlaylistSummaryDTO();
        }

        public async Task<PlaylistDeleteDTO> DeletePlaylistAsync(Guid userId, Guid playlistId)
        {
            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            bool playlistExist = await _context.Playlists.AnyAsync(p => p.Id == playlistId);
            if (!playlistExist) throw new KeyNotFoundException("Playlist you're trying to delete, doesn't exist.");

            var playlistQuery = await _context.Playlists
                                    .Where(p => p.UserId == userId && p.Id == playlistId)
                                    .Include(p => p.PlaylistRecipes)
                                    .FirstOrDefaultAsync();

            if (playlistQuery.UserId != userId) throw new UnauthorizedAccessException("You are not authorized to delete this playlist.");

            int recipeCount = playlistQuery.PlaylistRecipes?.Count ?? 0;

            _context.Playlists.Remove(playlistQuery);
            await _context.SaveChangesAsync();

            return new PlaylistDeleteDTO(
                playlistQuery.Name,
                recipeCount
            );
        }

        public async Task AddRecipeToPlaylistAsync(Guid userId, Guid playlistId, Guid recipeId)
        {
            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            var playlistQuery = await _context.Playlists
                                        .Include(p => p.PlaylistRecipes)
                                        .FirstOrDefaultAsync(p => p.UserId == userId && p.Id == playlistId);
            if (playlistQuery is null) throw new KeyNotFoundException("Playlist not found or not owner by the user.");

            var recipeQuery = await _context.Recipes.FirstOrDefaultAsync(r => r.Id == recipeId);
            if (recipeQuery is null) throw new KeyNotFoundException("The recipe you want to add does not exist.");
            if (recipeQuery.VisibilityStatus.ToLower() != "public") throw new ArgumentException("Only public recipes can be added to a playlist.");


            bool recipeInPlaylistExists = playlistQuery.PlaylistRecipes.Any(pr => pr.PlaylistId == playlistId && pr.RecipeId == recipeId);
            if (recipeInPlaylistExists) throw new ArgumentException("Recipe has already been added to the playlist.");

            var newPlaylistRecipe = new PlaylistRecipe
            {
                PlaylistId = playlistId,
                RecipeId = recipeId
            };

            await _context.PlaylistRecipes.AddAsync(newPlaylistRecipe);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> RemoveRecipeFromPlaylistAsync(Guid userId, Guid playlistId, Guid recipeId)
        {
            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            var playlistRecipeExists = await _context.PlaylistRecipes
                                            .FirstOrDefaultAsync(pr => pr.PlaylistId == playlistId && pr.RecipeId == recipeId);
            if (playlistRecipeExists is null) return false;

            _context.PlaylistRecipes.Remove(playlistRecipeExists);
            await _context.SaveChangesAsync();
            return true;
        }

        // Playlist Submission Block start

        public async Task<PagedResult<PlaylistSubmissionDetailsDTO>> GetMyPendingPlaylistsAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection)
        {
            if (page < 1 || pageSize < 1) throw new ArgumentOutOfRangeException("Page and or page size can not be less than 1.");

            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            bool isDescending = sortDirection.ToLower() == "desc";

            var pendingPlaylistsQuery = _context.Playlists
                                .Where(p => p.UserId == userId && p.VisibilityReviews.Any(vr => vr.VisibilityStatus == "pending"))
                                .Include(p => p.VisibilityReviews)
                                .Include(p => p.User)
                                .Include(p => p.HeartedByUsers)
                                .Include(p => p.PlaylistRecipes)
                                    .ThenInclude(pr => pr.Recipe)
                                        .ThenInclude(r => r.Country)
                                .Include(p => p.PlaylistRecipes)
                                    .ThenInclude(pr => pr.Recipe)
                                        .ThenInclude(r => r.User)
                                .Include(p => p.PlaylistRecipes)
                                    .ThenInclude(pr => pr.Recipe)
                                        .ThenInclude(r => r.Ratings)
                                .Include(p => p.PlaylistRecipes)
                                    .ThenInclude(pr => pr.Recipe)
                                        .ThenInclude(r => r.HeartedByUsers)
                                .AsQueryable();

            pendingPlaylistsQuery = sortBy.ToLower() switch
            {
                "submittedat" => isDescending
                                    ? pendingPlaylistsQuery.OrderByDescending(
                                        p => p.VisibilityReviews
                                            .Where(vr => vr.VisibilityStatus == "pending")
                                            .Max(vr => vr.SubmittedAt))
                                    : pendingPlaylistsQuery.OrderBy(
                                        p => p.VisibilityReviews
                                            .Where(vr => vr.VisibilityStatus == "pending")
                                            .Min(vr => vr.SubmittedAt)),
                _ => pendingPlaylistsQuery.OrderByDescending(
                        p => p.VisibilityReviews
                                .Where(vr => vr.VisibilityStatus == "pending")
                                .Max(vr => vr.SubmittedAt))
            };

            var totalPendingPlaylists = await pendingPlaylistsQuery.CountAsync();
            var pendingPlaylistsDTOs = await pendingPlaylistsQuery
                                    .Skip((page - 1) * pageSize)
                                    .Take(pageSize)
                                    .Select(r => r.ToPlaylistSubmissionDetailsDTO("pending"))
                                    .ToListAsync();

            return new PagedResult<PlaylistSubmissionDetailsDTO>
            {
                TotalCount = totalPendingPlaylists,
                CurrentPage = page,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalPendingPlaylists / (double)pageSize),
                Results = pendingPlaylistsDTOs
            };
        }

        public async Task<PagedResult<PlaylistSubmissionDetailsDTO>> GetMyDeniedPlaylistsAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResult<PlaylistSubmissionDetailsDTO>> GetMyApprovedPlaylistsAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection)
        {
            throw new NotImplementedException();
        }


        public async Task<PlaylistSubmissionResponseDTO> SubmitPlaylistSubmissionAsync(Guid userId, Guid playlistId)
        {
            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            var playlistModel = await _context.Playlists
                                        .Include(p => p.PlaylistRecipes)
                                        .Include(p => p.VisibilityReviews)
                                        .FirstOrDefaultAsync(p => p.UserId == userId && p.Id == playlistId);
            if (playlistModel is null) throw new KeyNotFoundException("Playlist you've added not found.");
            if (playlistModel.UserId != userId) throw new UnauthorizedAccessException("You are not authorized to unsubmit this playlist's submission.");

            if (playlistModel.PlaylistRecipes.Count() < 1) throw new ArgumentException("Cannot submit an empty playlist.");

            var pendingPlaylistSubmission = playlistModel.VisibilityReviews.FirstOrDefault(vr => vr.VisibilityStatus.ToLower() == "pending");
            if (pendingPlaylistSubmission is not null) throw new ArgumentException("This playlist already has a pending submission. Unsubmit previous submission in order to submit again.");

            playlistModel.VisibilityStatus = "pending";

            var newPlaylistVisibilityReview = new VisibilityReview
            {
                Id = Guid.NewGuid(),
                VisibilityStatus = "pending",
                SubmittedAt = DateTime.UtcNow,
                PlaylistId = playlistId
            };

            _context.VisibilityReviews.Add(newPlaylistVisibilityReview);
            await _context.SaveChangesAsync();

            return new PlaylistSubmissionResponseDTO(playlistId, "Your playlist has been submitted for review.");
        }

        public async Task<PlaylistSubmissionResponseDTO> UnSubmitPlaylistSubmissionAsync(Guid userId, Guid playlistId)
        {
            bool userCheck = await _context.Users.AnyAsync(u => u.Id == userId);
            if (!userCheck) throw new UnauthorizedAccessException("User that was passed to query was not found.");

            var playlistModel = await _context.Playlists
                                    .Include(p => p.VisibilityReviews)
                                    .FirstOrDefaultAsync(p => p.UserId == userId && p.Id == playlistId);
            if (playlistModel is null) throw new KeyNotFoundException("Playlist you've added not found.");
            if (playlistModel.UserId != userId) throw new UnauthorizedAccessException("You are not authorized to unsubmit this playlist's submission.");

            var pendingPlaylistSubmission = playlistModel.VisibilityReviews.FirstOrDefault(vr => vr.VisibilityStatus.ToLower() == "pending");
            if (pendingPlaylistSubmission is null) throw new ArgumentNullException("This playlist doesn't have a pending submission at this time.");

            _context.VisibilityReviews.Remove(pendingPlaylistSubmission);
            playlistModel.VisibilityStatus = "unlisted";
            await _context.SaveChangesAsync();

            return new PlaylistSubmissionResponseDTO(playlistId, "Pending playlist submission successfully.");
        }
    }
}