namespace StudentManagement.API.DTOs.Teacher
{
    public class UpdateTeacherDto
    {
        public record struct UpdateTeacherReqDto(string Name = "", string Email = "");
    }
}
