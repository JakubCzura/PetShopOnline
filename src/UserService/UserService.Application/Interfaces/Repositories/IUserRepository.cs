using UserService.Domain.Models.Entities;

namespace UserService.Application.Interfaces.Repositories;

/// <summary>
/// Fake repository for <see cref="User"/> entity.
/// </summary>
public interface IUserRepository
{
    /// <summary>
    /// Returns user by id.
    /// </summary>
    /// <param name="id">User's Id.</param>
    public User? GetById(int id);

    /// <summary>
    /// Returns all users.
    /// </summary>
    public IEnumerable<User> GetAll();

    /// <summary>
    /// Adds user to database.
    /// </summary>
    /// <param name="user">User to add to database.</param>
    /// <returns>User that was added to database.</returns>
    public User AddUser(User user);

    /// <summary>
    /// Deletes user from database by id.
    /// </summary>
    /// <param name="userId">User's id.</param>
    /// <returns>Number of rows deleted from database.</returns>
    public int DeleteUser(int userId);
}