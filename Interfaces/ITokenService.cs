using foodtopia.Models;

namespace foodtopia.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}