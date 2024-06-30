using UserService.Application.Interfaces.Repositories;
using UserService.Domain.Models.Entities;

namespace UserService.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    public User GetUser => new();

    public List<User> GetUsers =>
    [
        new User(),
        new User(),
        new User()
    ];

    public User AddUser(User user) => user;
}