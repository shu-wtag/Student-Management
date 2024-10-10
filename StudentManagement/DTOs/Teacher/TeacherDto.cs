namespace StudentManagement.API.DTOs.Teacher
{
    public record struct TeacherDto(int ID, string Name = "", string Email = "");
}
