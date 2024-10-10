namespace StudentManagement.API.DTOs.Course
{
    public record struct CreateCourseReqDto(int credits, string Course_Name = "");
}
