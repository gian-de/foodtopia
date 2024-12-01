
using foodtopia.Database;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetAll()
        {
            var recipes = _context.Countries.ToList();

            return Ok(recipes);
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] Guid id)
        {
            var recipe = _context.Countries.Find(id);

            if (recipe == null) return NotFound();

            return Ok(recipe);
        }
    }
}