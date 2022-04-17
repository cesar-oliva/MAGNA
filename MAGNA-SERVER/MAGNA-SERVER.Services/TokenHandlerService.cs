using MAGNA_SERVER.Abstractions;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace MAGNA_SERVER.Services
{
    public interface ITokenHandlerService
    {
        string GenerateJwtToken(ITokenParameters pars);
    }

    public class TokenHandlerService : ITokenHandlerService
    {
        private readonly JwtConfig _jwtConfig;

        /// <summary>
        /// security token handle
        /// </summary>
        /// <remarks>
        /// receives by dependency injection an object that implements the IOption Monitor interface
        /// </remarks>
        /// <param name="optionsMonitor"></param>
        public TokenHandlerService(IOptionsMonitor<JwtConfig> optionsMonitor)
        {
            _jwtConfig = optionsMonitor.CurrentValue;
        }

        /// <summary>
        /// Generate Token
        /// </summary>
        /// <remarks>
        /// we create an object that allows us to create a new token, then we create the key with which it will be signed and 
        /// then we create the token descriptor and pass the token attributes(id, username, email)
        /// </remarks>
        /// <param name="pars"></param>
        /// <returns>Token</returns>
        public string GenerateJwtToken(ITokenParameters pars)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
               {
                    new Claim("Id", pars.Id),
                    new Claim(JwtRegisteredClaimNames.Sub, pars.UserName),
                    new Claim(JwtRegisteredClaimNames.Email, pars.UserName),

                }),
                Expires = DateTime.UtcNow.AddHours(6),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)

            };
            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);
            return jwtToken;
        }

    }
}
