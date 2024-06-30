namespace AuthService.Domain.Responses;

/// <summary>
/// Response to sign in command.
/// </summary>
/// <param name="UserId">The ID of the user.</param>
/// <param name="Username">The username of the user.</param>
/// <param name="Email">The email of the user.</param>
/// <param name="JwtToken">The JWT token for authentication.</param>
public record SignInCommandResponse(int UserId,
                                    string Username,
                                    string Email,
                                    string JwtToken);
