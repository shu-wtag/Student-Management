using System.ComponentModel.DataAnnotations;

namespace StudentManagement.API.DTOs.Account
{
    public record struct LoginDto([Required] string Username = "", string Password = "");
}
