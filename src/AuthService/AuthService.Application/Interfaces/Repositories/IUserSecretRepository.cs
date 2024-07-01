using AuthService.Domain.Entities;

namespace AuthService.Application.Interfaces.Repositories;

/// <summary>
/// Fake repository for <see cref="UserSecret"/> entity.
/// </summary>
public interface IUserSecretRepository
{
    /// <summary>
    /// Returns all user secrets from database.
    /// </summary>
    /// <returns>All user secrets.</returns>
    IEnumerable<UserSecret> GetAll();

    /// <summary>
    /// Adds user secret to database.
    /// </summary>
    /// <param name="userSecret">User's secret to add to database.</param>
    /// <returns>User's secret that was added to database.</returns>
    UserSecret Add(UserSecret userSecret);
}