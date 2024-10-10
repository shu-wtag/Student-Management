using StudentManagement.Domain.Entities;

namespace StudentManagement.API.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}
