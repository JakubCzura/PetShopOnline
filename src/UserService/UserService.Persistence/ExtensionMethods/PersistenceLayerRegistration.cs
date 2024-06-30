using Microsoft.Extensions.DependencyInjection;
using UserService.Application.Interfaces.Repositories;
using UserService.Persistence.Repositories;

namespace UserService.Persistence.ExtensionMethods;

/// <summary>
/// Class to register persistence layer dependencies.
/// </summary>
public static class PersistenceLayerRegistration
{
    /// <summary>
    /// Register persistence layer dependencies.
    /// </summary>
    /// <param name="services">Collection of dependency injection services.</param>
    /// <returns><paramref name="services"/></returns>
    public static IServiceCollection AddPersistenceDI(this IServiceCollection services)
    {
        services.AddJwtAuthentication();
        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}