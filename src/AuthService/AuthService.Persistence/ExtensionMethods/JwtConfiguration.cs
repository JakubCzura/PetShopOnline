﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace AuthService.Persistence.ExtensionMethods;

/// <summary>
/// Class to configure JWT authentication.
/// </summary>
public static class JwtConfiguration
{
    /// <summary>
    /// Configure JWT authentication.
    /// </summary>
    /// <param name="services">Collection of dependency injection services.</param>
    /// <returns><paramref name="services"/></returns>
    public static IServiceCollection AddJwtAuthentication(this IServiceCollection services)
    {
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new()
            {
                ValidateIssuer = true,
                ValidIssuer = "PetShopOnline",
                ValidateAudience = true,
                ValidAudience = "PetShopOnline",
                ValidateLifetime = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("PLPL@#!Gsd454144fasdf@#!#fas$@!@nj%#@@3njd")),
                ValidateIssuerSigningKey = true
            };
        });
        return services;
    }
}