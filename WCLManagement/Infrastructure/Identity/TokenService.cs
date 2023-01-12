using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WCLManagement.Interfaces;
using Microsoft.Extensions.Configuration;

namespace WCLManagement.Infrastructure.Identity
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService( IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public TokenResponse GetToken(TokenRequest request)
        {
            var token = GenerateJwt();
            var result = new TokenResponse(token);
            return result;
        }

        public string GenerateJwt()
        {
            return GenerateEncryptedToken(GetSigningCredential());
        }

        private string GenerateEncryptedToken(SigningCredentials signingCredentials)
        {
            var claims = new[]
            {
                new Claim("Role", "Admin")
            };

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: signingCredentials);

            var tokenHandler = new JwtSecurityTokenHandler();

            return tokenHandler.WriteToken(token);
        }

        private SigningCredentials GetSigningCredential()
        {
            byte[] secret = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]);
                return new SigningCredentials(new SymmetricSecurityKey(secret),
            SecurityAlgorithms.HmacSha256);
        }

    }
}
