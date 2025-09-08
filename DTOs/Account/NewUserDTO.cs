namespace foodtopia.DTOs.Account
{
    public class NewUserDTO
    {
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public required string JwtToken { get; set; }
        public required string Role { get; set; }
    }
}