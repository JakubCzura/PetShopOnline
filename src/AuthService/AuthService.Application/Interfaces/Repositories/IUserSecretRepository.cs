using AuthService.Domain.Entities;

namespace AuthService.Application.Interfaces.Repositories;

public interface IUserSecretRepository
{
    IEnumerable<UserSecret> GetAll();

    UserSecret Add(UserSecret userSecret);
}