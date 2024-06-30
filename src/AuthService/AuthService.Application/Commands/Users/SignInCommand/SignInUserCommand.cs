using AuthService.Domain.Responses;
using MediatR;

namespace AuthService.Application.Commands.Users.SignInCommand;

/// <summary>
/// Command to sign in user.
/// </summary>
/// <param name="Email">User's email.</param>
/// <param name="Username">User's username.</param>
/// <param name="Password">User's password.</param>
public record SignInUserCommand(string Email,
                                string Username,
                                string Password) : IRequest<SignInCommandResponse>;