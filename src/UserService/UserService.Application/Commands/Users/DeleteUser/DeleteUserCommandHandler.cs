using MediatR;
using UserService.Application.Interfaces.Repositories;

namespace UserService.Application.Commands.Users.DeleteUser;

/// <summary>
/// Handler to delete a user.
/// </summary>
/// <param name="userRepository">Repository to manage user entity.</param>
public class DeleteUserCommandHandler(IUserRepository userRepository) : IRequestHandler<DeleteUserCommand, int>
{
    /// <summary>
    /// Deletes a user from the database.
    /// </summary>
    /// <param name="request">Request to delete a user.</param>
    /// <param name="cancellationToken">Token to cancel asynchronous operations.</param>
    /// <returns>Number of rows deleted from database.</returns>
    public Task<int> Handle(DeleteUserCommand request,
                            CancellationToken cancellationToken)
        => Task.FromResult(userRepository.DeleteUser(request.UserId));
}