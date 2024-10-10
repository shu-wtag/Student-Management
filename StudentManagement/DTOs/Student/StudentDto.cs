using System.ComponentModel.DataAnnotations;

namespace StudentManagement.API.DTOs.Student
{
    public record struct StudentDto(
        [Required] int ID,
        [Required, MinLength(5, ErrorMessage = "Name must be 5 characters")] string Name = "",
        string Email = "");
}
