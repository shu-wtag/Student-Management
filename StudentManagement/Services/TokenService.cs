using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using StudentManagement.API.Interfaces;
using StudentManagement.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StudentManagement.API.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _config;
        private readonly SymmetricSecurityKey _key;
        private readonly UserManager<AppUser> _userManager;

        public TokenService(IConfiguration Config, UserManager<AppUser> userManager) //pull staffs from appSettins.Json
        {
            _config = Config;
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:SigningKey"]));
            _userManager = userManager;//GetBytes for breaking the string 
        }
        public async Task<string> CreateToken(AppUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.GivenName, user.Email)
            };
            
            //Signing Credentials means what type of encryption do I want
            var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature); //_key is in appSettings.Json

            //Create the Token (Object representation of a token
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds,
                Issuer = _config["JWT:Issuer"],
                Audience = _config["JWT:Audience"]
            };

            //Token handler which is going to actually create token
            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token); // returnung token as string not object
        }
    }
}
