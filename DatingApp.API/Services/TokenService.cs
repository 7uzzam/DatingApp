using DatingApp.API.Entites;
using DatingApp.API.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DatingApp.API.Services
{
    public class TokenService : ITokenService
    {
        private readonly SymmetricSecurityKey _key;
        public TokenService(IConfiguration config)
        {
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["TokenKey"])); //Generating a key to be used in Token Encryption
        }
        string ITokenService.CreateToken(AppUser user)
        {
            var claims = new List<Claim> // Adding Claims
            {
                new Claim(JwtRegisteredClaimNames.NameId, user.UserName)
            };

            var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature); //Creating Credentials

            var tokenDescripter = new SecurityTokenDescriptor //Discribing How token is going to look
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(7),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler(); //Creating Token Handler to handle the token

            var token = tokenHandler.CreateToken(tokenDescripter); //Creating the actual token

            return tokenHandler.WriteToken(token); //returning the token
        }
    }
}
