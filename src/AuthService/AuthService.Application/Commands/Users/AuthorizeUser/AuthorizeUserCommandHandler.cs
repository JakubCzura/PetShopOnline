using AuthService.Application.Interfaces.Auth;
using AuthService.Domain.Responses;
using MediatR;

namespace AuthService.Application.Commands.Users.AuthorizeUser;

/// <summary>
/// Handler to authorize user and return jwt token.
/// </summary>
/// <param name="jwtTokenService">Service to return jwt token.</param>
public class AuthorizeUserCommandHandler(IJwtTokenService jwtTokenService) : IRequestHandler<AuthorizeUserCommand, AuthorizeUserResponse>
{
    /// <summary>
    /// Authorizes user and returns jwt token.
    /// </summary>
    /// <param name="request">Command with details to authorize user.</param>
    /// <param name="cancellationToken">Token to cancell asynchronous operation.</param>
    /// <returns><see cref="Task"/></returns>
    public Task<AuthorizeUserResponse> Handle(AuthorizeUserCommand request,
                                              CancellationToken cancellationToken)
    {
        //Sample user roles.
        //In real application, user's roles should be fetched from database.
        //I use "User" role for simplicity in the application for demo purposes.
        List<string> userRoles = ["User"];
        string jwt = jwtTokenService.GenerateJwtToken(request.Id, request.Email, request.Username, userRoles);
        return Task.FromResult(new AuthorizeUserResponse(request.Id, request.Username, request.Email, jwt));
    }
}