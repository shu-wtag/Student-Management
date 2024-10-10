using System.ComponentModel.DataAnnotations;

namespace StudentManagement.API.DTOs
{
    public record  RegisterDto
    {
        [Required]
        public string? username { get; set; }
        [Required]
        [EmailAddress] // dotnet core provide automatic email validation
        public string? emailAddress { get; set; }
        [Required]
        public string? password { get; set; }

    }
}
