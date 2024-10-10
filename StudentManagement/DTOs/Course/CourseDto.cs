namespace StudentManagement.API.DTOs.Course
{
    public record struct CourseDto(int ID, int Credits, string Course_Name = "");
}
