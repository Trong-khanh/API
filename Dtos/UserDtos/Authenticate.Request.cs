using System.ComponentModel.DataAnnotations;

namespace webAPI.Dtos.UserDtos
{
    public class AuthenticateRequest
    {
        
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}