using MediatR;
using UserService.Domain.Models.Entities;

namespace UserService.Application.Commands.Users.CreateUser;

/// <summary>
/// Command to create a new user.
/// </summary>
/// <param name="Name">User's name.</param>
/// <param name="Email">User's email.</param>
/// <param name="Password">User's password.</param>
public record CreateUserCommand(string Name,
                                string Email,
                                string Password) : IRequest<User>;