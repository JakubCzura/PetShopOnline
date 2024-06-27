using AuthService.Application.Interfaces.Auth;
using AuthService.Domain.Responses;
using MediatR;

namespace AuthService.Application.Commands.Users.SignUpCommand;

public class SignInUserCommandHandler(IJwtTokenService jwtTokenService) : IRequestHandler<SignInUserCommand, SignInCommandResponse>
{
    public async Task<SignInCommandResponse> Handle(SignInUserCommand request,
                                                    CancellationToken cancellationToken)
    {
        string jwt = jwtTokenService.GenerateJwtToken(1, request.Email, request.Username, ["User"]);

        return new SignInCommandResponse(1, request.Username, request.Email, jwt);
    }
}