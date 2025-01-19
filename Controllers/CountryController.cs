using foodtopia.Database;
using foodtopia.DTOs.Country;
using foodtopia.DTOs.Recipe;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace foodtopia.Controllers
{
    [Route("api/countries")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CountryController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var countries = await _context.Countries
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

            return Ok(countries);
        }

        [HttpGet("{slug}")]
        public async Task<IActionResult> GetOne([FromRoute] string slug)
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

            if (country == null) return NotFound();

            return Ok(country);
        }
    }
}