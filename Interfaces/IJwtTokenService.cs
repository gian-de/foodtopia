using foodtopia.Models;

namespace foodtopia.Interfaces
{
    public interface IJwtTokenService
    {
        string CreateToken(AppUser user);
    }
}