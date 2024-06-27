using AuthService.Application.Interfaces.Auth;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthService.Persistence.Auth;

internal class JwtTokenService : IJwtTokenService
{
    public string GenerateJwtToken(int UserId,
                                   string Email,
                                   string Username,
                                   IEnumerable<string>? roles = null,
                                   IEnumerable<Claim>? claims = null)
    {
        List<Claim> tokenClaims =
        [
            new Claim(ClaimTypes.NameIdentifier, UserId.ToString()),
            new Claim(ClaimTypes.Email, Email),
            new Claim(ClaimTypes.Name, Username),
        ];

        if (roles?.Any() == true)
        {
            IEnumerable<Claim> tokenRoles = roles.Select(role => new Claim(ClaimTypes.Role, role));
            tokenClaims.AddRange(tokenRoles);
        }

        if (claims?.Any() == true)
        {
            tokenClaims.AddRange(claims);
        }

        SymmetricSecurityKey symmetricSecurityKey = new(Encoding.UTF8.GetBytes("PLPL@#!Gsd454144fasdf@#!#fas$@!@nj%#@@3njd"));
        SigningCredentials signingCredentials = new(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
        DateTime expires = DateTime.UtcNow.AddDays(1);

        JwtSecurityToken jwtSecurityToken = new(issuer: "PetShopOnline",
                                                audience: "PetShopOnline",
                                                claims: tokenClaims,
                                                expires: expires,
                                                signingCredentials: signingCredentials);

        return new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
    }
}