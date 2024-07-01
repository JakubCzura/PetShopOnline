using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Entities;

namespace AuthService.Persistence.Persistence;

internal class UserSecretRepository : IUserSecretRepository
{
    private readonly List<UserSecret> _userSecrets =
    [
        new UserSecret { Id = 1, SecretInfo = "Something secret about user" },
        new UserSecret { Id = 1, SecretInfo = "It's top secret" },
    ];

    public IEnumerable<UserSecret> GetAll() => _userSecrets;

    public UserSecret Add(UserSecret userSecret)
    {
        int maxId = _userSecrets.Max(x => x.Id);
        userSecret.Id = maxId + 1;
        _userSecrets.Add(userSecret);
        return userSecret;
    }
}