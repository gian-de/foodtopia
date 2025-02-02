using foodtopia.DTOs.Country;

namespace foodtopia.Interfaces
{
    public interface ICountryService
    {
        Task<List<CountryDTO>> GetAllCountriesAsync();
        Task<CountryDTO?> GetCountryBySlugAsync(string slug);
    }
}