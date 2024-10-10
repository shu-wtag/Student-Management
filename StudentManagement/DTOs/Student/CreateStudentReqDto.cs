namespace StudentManagement.API.DTOs.Student
{
    public record struct CreateStudentReqDto(string Name = "", string Email = "");
}
