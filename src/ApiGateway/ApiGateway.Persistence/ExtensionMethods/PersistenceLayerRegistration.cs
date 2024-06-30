using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiGateway.Persistence.ExtensionMethods;

public static class PersistenceLayerRegistration
{
    public static IServiceCollection AddPersistenceDI(this IServiceCollection services,
                                                      IConfiguration configuration)
    {
        services.AddJwtAuthentication();

        return services;
    }
}