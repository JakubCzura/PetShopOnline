using MediatR;
using UserService.Application.Interfaces.Repositories;
using UserService.Domain.Models.Entities;

namespace UserService.Application.Queries.Users.GetAll;

/// <summary>
/// Handler to retrieve all users from database.
/// </summary>
/// <param name="userRepository">Repository for managing user entity.</param>
public class GetAllUsersQueryHandler(IUserRepository userRepository)
    : IRequestHandler<GetAllUsersQuery, IEnumerable<User>>
{
    /// <summary>
    /// Returns all users from database.
    /// </summary>
    /// <param name="request">Request for getting all users.</param>
    /// <param name="cancellationToken">Token to cancel asynchronous operations.</param>
    /// <returns>All users from database.</returns>
    public Task<IEnumerable<User>> Handle(GetAllUsersQuery request,
                                          CancellationToken cancellationToken)
        => Task.FromResult(userRepository.GetAll());
}