using UserService.Domain.Models.Entities;

namespace UserService.Application.Interfaces.Repositories;

/// <summary>
/// Let's imagine that this repository is connected to a database.
/// </summary>
public interface IUserRepository
{
    public User GetUser { get; }

    public List<User> GetUsers { get; }

    public int AddUser(User user);
}