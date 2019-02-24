using System.ComponentModel.DataAnnotations;

namespace SearchItFindIt_Lib.Models
{
    public class LoginDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

    }

    public class RegisterDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "PASSWORD_MIN_LENGTH", MinimumLength = 6)]
        public string Password { get; set; }
    }
}