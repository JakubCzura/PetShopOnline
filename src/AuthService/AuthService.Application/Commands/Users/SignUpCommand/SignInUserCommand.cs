using AuthService.Domain.Responses;
using MediatR;

namespace AuthService.Application.Commands.Users.SignUpCommand;

public record SignInUserCommand(string Email,
                                string Username,
                                string Password) : IRequest<SignInCommandResponse>;