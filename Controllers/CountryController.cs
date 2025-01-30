using foodtopia.Services;
using Microsoft.AspNetCore.Mvc;

namespace foodtopia.Controllers
{
    [Route("api/countries")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly CountryService _countryService;
        public CountryController(CountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var countries = await _countryService.GetAllCountriesAsync();
            return Ok(countries);
        }

        [HttpGet("{slug}")]
        public async Task<IActionResult> GetOne([FromRoute] string slug)
        {
            try
            {
                var country = await _countryService.GetCountryBySlugAsync(slug);
                return Ok(country);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { ex.Message });
            }
        }
    }
}