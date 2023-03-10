using System.ComponentModel.DataAnnotations;

namespace RoleIdentity.Models
{
    public class UserRegisterRequest
    {
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required, MinLength(6, ErrorMessage = "Enter at least 6 character")]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
