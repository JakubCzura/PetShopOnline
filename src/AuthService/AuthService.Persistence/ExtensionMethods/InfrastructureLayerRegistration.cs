using AuthService.Application.Interfaces.Auth;
using AuthService.Persistence.Auth;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthService.Persistence.ExtensionMethods;

public static class InfrastructureLayerRegistration
{
    public static IServiceCollection AddInfrastructureDI(this IServiceCollection services,
                                                         IConfiguration configuration)
    {
        services.AddScoped<IJwtTokenService, JwtTokenService>();
        services.AddJwtAuthentication();

        return services;
    }
}