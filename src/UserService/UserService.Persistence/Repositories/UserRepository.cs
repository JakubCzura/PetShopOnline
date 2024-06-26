using UserService.Application.Interfaces.Repositories;
using UserService.Domain.Models.Entities;

namespace UserService.Persistence.Repositories;

/// <summary>
/// Let's imagine that this repository is connected to a database.
/// </summary>
public class UserRepository : IUserRepository
{
    public User GetUser => new();

    public List<User> GetUsers =>
    [
        new User(),
        new User(),
        new User()
    ];

    public int AddUser(User user) => user.Id;
}