namespace StudentManagement.API.DTOs.Account
{
    public record struct NewUserDto(string UserName = "", string Email = "", string Role ="User", string Token = "");
}
