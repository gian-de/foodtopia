using foodtopia.Database;
using foodtopia.DTOs.Playlist;
using foodtopia.Helpers;
using foodtopia.Interfaces;
using foodtopia.Mappings.Playlists;
using Microsoft.AspNetCore.Http.HttpResults;
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

            var playlistModel = playlistCreateDTO.ToPlaylistModelFromDTO();
            playlistModel.UserId = userId;
            playlistModel.FullSlug = fullSlug;

            _context.Playlists.Add(playlistModel);
            await _context.SaveChangesAsync();

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
    }
}