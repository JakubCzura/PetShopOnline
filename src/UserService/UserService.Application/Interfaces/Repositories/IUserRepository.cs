using UserService.Domain.Models.Entities;

namespace UserService.Application.Interfaces.Repositories;

/// <summary>
/// Let's imagine that this repository is connected to a database.
/// It's designed to take care of <see cref="User"/> entity.
/// </summary>
public interface IUserRepository
{
    public User GetUser { get; }

    public List<User> GetUsers { get; }

    public User AddUser(User user);
}