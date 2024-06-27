namespace AuthService.Domain.Responses;

public record SignInCommandResponse(int UserId,
                                    string Username,
                                    string Email,
                                    string JwtToken);