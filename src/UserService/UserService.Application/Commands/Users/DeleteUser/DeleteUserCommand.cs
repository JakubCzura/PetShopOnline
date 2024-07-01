using MediatR;

namespace UserService.Application.Commands.Users.DeleteUser;

/// <summary>
/// Request to delete a user.
/// </summary>
/// <param name="UserId">User's id.</param>
public record DeleteUserCommand(int UserId) : IRequest<int>;