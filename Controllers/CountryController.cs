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
                .Include(c => c.Recipes)
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
                        r.HeartCount,
                        r.TasteReviewCount,
                        r.DifficultyReviewCount
                    )).ToList()
                ))
                .ToListAsync();

            return Ok(countries);
        }

        [HttpGet("{slug}")]
        public async Task<IActionResult> GetOne([FromRoute] string slug)
        {
            var country = await _context.Countries
            .Include(c => c.Recipes)
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
                    r.HeartCount,
                    r.TasteAverage,
                    r.DifficultyAverage
                )).ToList()
            ))
            .FirstOrDefaultAsync();

            if (country == null) return NotFound();

            return Ok(country);
        }
    }
}