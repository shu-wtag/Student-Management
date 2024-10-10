namespace StudentManagement.API.DTOs.Course
{
    public record struct UpdateCourseReqDto(int Credits, string Course_Name = "" );
}
