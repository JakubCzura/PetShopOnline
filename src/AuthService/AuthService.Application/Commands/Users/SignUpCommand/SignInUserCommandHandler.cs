using AuthService.Application.Interfaces.Auth;
using AuthService.Domain.Responses;
using MediatR;

namespace AuthService.Application.Commands.Users.SignUpCommand;

/// <summary>
/// Handler to sign in user and return jwt token.
/// </summary>
/// <param name="jwtTokenService">Service to return jwt token.</param>
public class SignInUserCommandHandler(IJwtTokenService jwtTokenService) : IRequestHandler<SignInUserCommand, SignInCommandResponse>
{
    /// <summary>
    /// Signs in user and returns jwt token.
    /// </summary>
    /// <param name="request">Command with details to sign in user.</param>
    /// <param name="cancellationToken">Token to cancell asynchronous operation.</param>
    /// <returns><see cref="Task"/></returns>
    public async Task<SignInCommandResponse> Handle(SignInUserCommand request,
                                                    CancellationToken cancellationToken)
    {
        string jwt = jwtTokenService.GenerateJwtToken(1, request.Email, request.Username, ["User"]);
        return new SignInCommandResponse(1, request.Username, request.Email, jwt);
    }
}