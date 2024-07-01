using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Entities;
using MediatR;

namespace AuthService.Application.Queries.Users.GetAll;

/// <summary>
/// Handler to get secret info about users.
/// </summary>
public class GetAllSecretInfosQueryHandler(IUserSecretRepository userSecretRepository) 
    : IRequestHandler<GetAllSecretInfosQuery, IEnumerable<UserSecret>>
{
    /// <summary>
    /// Let's imagine that this handler gets secret info about user from database.
    /// </summary>
    /// <param name="request">Request to get users' secrets from database.</param>
    /// <param name="cancellationToken">Token to cancel asynchronous operations.</param>
    /// <returns><see cref="Task"/></returns>
    public Task<IEnumerable<UserSecret>> Handle(GetAllSecretInfosQuery request, 
                                                CancellationToken cancellationToken)  
        => Task.FromResult(userSecretRepository.GetAll());
    
}