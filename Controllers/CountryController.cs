using foodtopia.Database;
using foodtopia.Dtos.Recipe;
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

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] Guid id)
        {
            var country = _context.Countries.Find(id);

            if (country == null) return NotFound();

            return Ok(country);
        }
    }
}