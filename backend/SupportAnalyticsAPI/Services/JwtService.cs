using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using SupportAnalyticsAPI.Models;

namespace SupportAnalyticsAPI.Services
{
    public class JwtService
    {
        private string secureKey="THIS_IS_SECRET";

        public string Generate(User user)
        {
            var symmetricSecurityKey=
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(secureKey));

            var credentials=
                new SigningCredentials(
                    symmetricSecurityKey,
                    SecurityAlgorithms.HmacSha256);

            var header=new JwtHeader(credentials);

            var claims=new[]
            {
                new Claim(ClaimTypes.Name,user.Username)
            };

            var payload=new JwtPayload(
                claims:claims,
                expires:DateTime.Now.AddHours(2));

            var token=new JwtSecurityToken(header,payload);

            return new JwtSecurityTokenHandler()
                .WriteToken(token);
        }
    }
}