namespace StudentManagement.API.DTOs.Enrollment
{
    public record struct CreateEnrollReqDto(int Std_id, int Crs_id, string Enroll_date = "");
}
