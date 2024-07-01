namespace AuthService.Domain.Responses;

/// <summary>
/// Response to sign in command.
/// </summary>
/// <param name="UserId">User's Id.</param>
/// <param name="Username">User's username.</param>
/// <param name="Email">User's email.</param>
/// <param name="JwtToken">JWT for auth purposes.</param>
public record AuthorizeUserResponse(int UserId,
                                    string Username,
                                    string Email,
                                    string JwtToken);