using foodtopia.Database;
using foodtopia.DTOs.Country;
using foodtopia.DTOs.Recipe;
using Microsoft.EntityFrameworkCore;

namespace foodtopia.Services
{
    public class CountryService
    {
        private readonly AppDbContext _context;

        public CountryService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<CountryDTO>> GetAllCountriesAsync()
        {
            return await _context.Countries
                .Include(c => c.Recipes!)
                .ThenInclude(r => r.HeartedByUsers) // Include Recipes's other foreign key relationship
                .OrderBy(c => c.Name)
                .Select(c => new CountryDTO
                (
                    c.Id,
                    c.Name,
                    c.Slug,
                    c.ImagePath,
                    c.Recipes != null
                    ? c.Recipes.Select(r => new RecipeTldrDTO
                    (
                        r.Id,
                        r.Name,
                        r.CountryId,
                        r.ImageUrl,
                        r.TasteAverage,
                        r.DifficultyAverage,
                        r.HeartedByUsers != null ? r.HeartedByUsers.Count : 0
                    )).ToList()
                    : new List<RecipeTldrDTO>()
                ))
                .ToListAsync();
        }

        public async Task<CountryDTO?> GetCountryBySlugAsync(string slug)
        {
            var country = await _context.Countries
            .Include(c => c.Recipes!)
            .ThenInclude(r => r.HeartedByUsers) // Include Recipes's other foreign key relationship
            .Where(c => c.Slug == slug)
            .Select(c => new CountryDTO
            (
                c.Id,
                c.Name,
                c.Slug,
                c.ImagePath,
                c.Recipes.Select(r => new RecipeTldrDTO
                (
                    r.Id,
                    r.Name,
                    r.CountryId,
                    r.ImageUrl,
                    r.TasteAverage,
                    r.DifficultyAverage,
                    r.HeartedByUsers != null ? r.HeartedByUsers.Count : 0
                )).ToList()
            ))
            .FirstOrDefaultAsync();

            if (country is null) throw new KeyNotFoundException($"Country with slug \"{slug}\" not found.");

            return country;
        }
    }
}