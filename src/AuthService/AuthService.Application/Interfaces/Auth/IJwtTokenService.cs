using System.Security.Claims;

namespace AuthService.Application.Interfaces.Auth;

/// <summary>
/// Token service to generate jwt token.
/// </summary>
public interface IJwtTokenService
{
    /// <summary>
    /// Generates jwt token.
    /// </summary>
    /// <param name="UserId">User's id.</param>
    /// <param name="Email">User's email.</param>
    /// <param name="Username">User's username.</param>
    /// <param name="roles">User's roles.</param>
    /// <param name="claims">User's claims.</param>
    /// <returns>Jwt token.</returns>
    public string GenerateJwtToken(int UserId,
                                   string Email,
                                   string Username,
                                   IEnumerable<string>? roles = null,
                                   IEnumerable<Claim>? claims = null);
}