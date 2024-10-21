namespace StudentManagement.API.DTOs.Student
{
    public record struct UpdateStudentReqDto(string Name = "",string Email = "");
}
