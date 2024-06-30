using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AccessoryService.Application.ExtensionMethods;

/// <summary>
/// Class to register application layer dependencies.
/// </summary>
public static class ApplicationLayerRegistration
{
    /// <summary>
    /// Register application layer dependencies.
    /// </summary>
    /// <param name="services">Collection of dependency injection services.</param>
    /// <returns><paramref name="services"/></returns>
    public static IServiceCollection AddApplicationDI(this IServiceCollection services)
    {
        services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        return services;
    }
}