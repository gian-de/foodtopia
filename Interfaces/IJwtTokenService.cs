using foodtopia.Models;

namespace foodtopia.Interfaces
{
    public interface IJwtTokenService
    {
        Task<string> CreateTokenAsync(AppUser user);
    }
}