using System.ComponentModel.DataAnnotations;

namespace foodtopia.DTOs.Account
{
    public class LoginDTO
    {
        // Data annotations for error response
        [Required]
        // "public required" - to silence non-null warning yellow squiggly 
        public required string Username { get; set; }

        [Required]
        public required string Password { get; set; }
    }
}