using MediatR;
using UserService.Application.Interfaces.Repositories;
using UserService.Domain.Models.Entities;

namespace UserService.Application.Commands.Users.CreateUser;

/// <summary>
/// Handler to create a new user.
/// </summary>
/// <param name="userRepository">Repository to manage user entity.</param>
public class CreateUserCommandHandler(IUserRepository userRepository)
    : IRequestHandler<CreateUserCommand, User>
{

    /// <summary>
    /// Adds a new user to the database.
    /// </summary>
    /// <param name="request">Request to create a new user.</param>
    /// <param name="cancellationToken">Token to cancel asynchronous operations.</param>
    /// <returns>A new user.</returns>
    public Task<User> Handle(CreateUserCommand request, 
                             CancellationToken cancellationToken)
        => Task.FromResult(userRepository.AddUser(new User() { Name = request.Name, Email = request.Email, Password = request.Password }));
}