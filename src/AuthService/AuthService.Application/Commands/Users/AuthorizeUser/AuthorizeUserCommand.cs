using AuthService.Domain.Responses;
using MediatR;

namespace AuthService.Application.Commands.Users.AuthorizeUser;

/// <summary>
/// Command to authorize user and return jwt token.
/// </summary>
/// <param name="Id">User's Id from database.</param>
/// <param name="Email">User's email.</param>
/// <param name="Username">User's username.</param>
/// <param name="Password">User's password.</param>
public record AuthorizeUserCommand(int Id,
                                   string Email,
                                   string Username,
                                   string Password) : IRequest<AuthorizeUserResponse>;