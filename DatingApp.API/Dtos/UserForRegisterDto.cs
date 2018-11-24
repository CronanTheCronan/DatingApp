using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "You must choose a password between 10 and 20 characters.")]
        public string Password { get; set; }
    }
}