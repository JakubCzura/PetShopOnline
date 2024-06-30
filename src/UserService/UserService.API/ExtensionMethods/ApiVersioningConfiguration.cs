using Asp.Versioning;

namespace UserService.API.ExtensionMethods;

/// <summary>
/// Extension methods to register API versioning.
/// </summary>
public static class ApiVersioningConfiguration
{
    /// <summary>
    /// Configures API versioning.
    /// </summary>
    /// <param name="services">Collection of dependency injection services.</param>
    /// <returns><paramref name="services"/>.</returns>
    public static IServiceCollection AddApiVersion(this IServiceCollection services)
    {
        services.AddApiVersioning(config =>
        {
            config.AssumeDefaultVersionWhenUnspecified = true;
            config.DefaultApiVersion = ApiVersioningInfo.CurrentVersion;
            config.ReportApiVersions = true;
            config.ApiVersionReader = new UrlSegmentApiVersionReader();
        });

        return services;
    }
}