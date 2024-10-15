using System.ComponentModel.DataAnnotations;

namespace StudentManagement.API.DTOs
{
    public record RegisterDto
    {
        [Required(ErrorMessage = "Username is required.")]
        public string username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string emailAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(12, ErrorMessage = "Password must be at least 12 characters long.")]
        public string password { get; set; } = string.Empty;
    }
}
