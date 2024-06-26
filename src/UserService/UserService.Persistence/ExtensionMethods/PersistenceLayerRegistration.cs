using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserService.Application.Interfaces.Repositories;
using UserService.Persistence.Repositories;

namespace UserService.Persistence.ExtensionMethods;

public static class PersistenceLayerRegistration
{
    public static IServiceCollection AddPersistenceDI(this IServiceCollection services,
                                                      IConfiguration configuration)
    {
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}