using MediatR;
using UserService.Application.Interfaces.Repositories;
using UserService.Domain.Models.Entities;

namespace UserService.Application.Queries.Users.GetById;

/// <summary>
/// Handler to get a user by id.
/// </summary>
/// <param name="userRepository">Repository to manage user entity.</param>
public class GetUserByIdQueryHandler(IUserRepository userRepository)
    : IRequestHandler<GetUserByIdQuery, User?>
{
    public Task<User?> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        => Task.FromResult(userRepository.GetById(request.UserId));
}