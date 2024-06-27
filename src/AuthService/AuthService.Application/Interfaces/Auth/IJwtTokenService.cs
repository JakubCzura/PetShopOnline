using System.Security.Claims;

namespace AuthService.Application.Interfaces.Auth;

public interface IJwtTokenService
{
    public string GenerateJwtToken(int UserId,
                                   string Email,
                                   string Username,
                                   IEnumerable<string>? roles = null,
                                   IEnumerable<Claim>? claims = null);
}