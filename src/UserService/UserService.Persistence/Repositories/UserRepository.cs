using UserService.Application.Interfaces.Repositories;
using UserService.Domain.Models.Entities;

namespace UserService.Persistence.Repositories;

internal class UserRepository : IUserRepository
{
    private readonly List<User> _users =
    [
        new User() { Id = 1, Name = "John", Email = "john@email.com", Password = "Pass123" },
        new User() { Id = 2, Name = "Johny", Email = "johny@email.com", Password = "Pass1234" },
        new User() { Id = 3, Name = "Kris", Email = "kris@email.com", Password = "Pass1235" },
        new User() { Id = 4, Name = "Bernadeth", Email = "bernadeth@email.com", Password = "Pass1236" },
        new User() { Id = 5, Name = "Britney", Email = "britney@email.com", Password = "Pass1237" },
    ];

    public User? GetById(int id) => _users.FirstOrDefault(x => x.Id == id);

    public IEnumerable<User> GetAll() => _users;

    public User AddUser(User user)
    {
        int maxId = _users.Max(x => x.Id);
        user.Id = maxId + 1;
        _users.Add(user);
        return user;
    }

    public int DeleteUser(int userId)
    {
        User? user = _users.FirstOrDefault(x => x.Id == userId);
        if (user is null)
        {
            return 0;
        }

        _users.Remove(user);
        return 1;
    }
}