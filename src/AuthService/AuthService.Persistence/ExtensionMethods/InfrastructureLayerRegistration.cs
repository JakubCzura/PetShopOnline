using AuthService.Application.Interfaces.Auth;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Persistence.Auth;
using Microsoft.Extensions.DependencyInjection;

namespace AuthService.Persistence.ExtensionMethods;

/// <summary>
/// Class to register infrastructure layer dependencies.
/// </summary>
public static class InfrastructureLayerRegistration
{
    /// <summary>
    /// Register infrastructure layer dependencies.
    /// </summary>
    /// <param name="services">Collection of dependency injection services.</param>
    /// <returns><paramref name="services"/></returns>
    public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
    {
        services.AddScoped<IJwtTokenService, JwtTokenService>();
        services.AddScoped<IUserSecretRepository, IUserSecretRepository>();
        services.AddJwtAuthentication();

        return services;
    }
}