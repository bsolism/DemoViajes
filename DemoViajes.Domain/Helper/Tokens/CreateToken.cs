using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DemoViajes.Domain.Helper.Tokens
{
    public class CreateToken
    {
        public CreateToken()
        {

        }
        private SymmetricSecurityKey Key()
        {
            var secretKey = "abcdefghijklmnopqrstuvwxyz0123456789";
            var key = new SymmetricSecurityKey(Encoding.UTF8
            .GetBytes(secretKey));
            return key;
        }
        private SigningCredentials SigningCredentials(SymmetricSecurityKey key)
        {
            return new SigningCredentials(
                key, SecurityAlgorithms.HmacSha256Signature
            );
        }

        public string CreateJWT(User user)
        {
            var key = Key();
            var claims = new Claim[]{
                new Claim("userName", user.UserName),
                new Claim("password", user.Password)
            };
            var signingCredentials = new SigningCredentials(
                key, SecurityAlgorithms.HmacSha256Signature
            );
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(180),
                SigningCredentials = signingCredentials
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

    }
}
