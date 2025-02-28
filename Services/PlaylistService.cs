using foodtopia.Database;
using foodtopia.DTOs.Playlist;
using foodtopia.Helpers;
using foodtopia.Interfaces;
using foodtopia.Mappings.Playlists;
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

        public async Task<PlaylistSummaryDTO> GetPlaylistByIdAsync(Guid playlistId)
        {
            var playlistQuery = await _context.Playlists
                                    .Where(p => p.Id == playlistId)
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

            if (playlistQuery is null) throw new KeyNotFoundException($"Playlist with id {playlistId} was not found.");
            return playlistQuery.ToPlaylistSummaryDTO();
        }

        public async Task<PagedResult<PlaylistSummaryDTO>> GetMyCreatedPlaylistsAsync(Guid userId, int page, int pageSize, string sortBy, string sortDirection)
        {
            if (page < 1 || pageSize < 1) throw new ArgumentException("Page and or Page size must be greater than 0.");

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

    }
}