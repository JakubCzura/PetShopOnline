using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Entities;
using MediatR;

namespace AuthService.Application.Commands.Users.CreateSecretInfo;

/// <summary>
/// Handler to create secret info about user and add it to database.
/// </summary>
public class CreateSecretInfoCommandHandler(IUserSecretRepository userSecretRepository) :
    IRequestHandler<CreateSecretInfoCommand, UserSecret>
{
    /// <summary>
    /// Let's imagine that this handler creates secret info about user and adds it to database.
    /// </summary>
    /// <param name="request">Request with details to add secret info to database.</param>
    /// <param name="cancellationToken">Token to cancel asynchronous operations.</param>
    /// <returns>Secret that was added to database.</returns>
    public Task<UserSecret> Handle(CreateSecretInfoCommand request,
                                   CancellationToken cancellationToken)
        => Task.FromResult(userSecretRepository.Add(new() { SecretInfo = request.SecretInfo }));
}