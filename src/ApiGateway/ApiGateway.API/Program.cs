WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//TODO: Implement authentication, look at UserService and AuthService for guidance
//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//    .AddJwtBearer();

builder.Services.AddReverseProxy()
                .LoadFromConfig(builder.Configuration.GetSection("ApiGateway"));

WebApplication app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthentication();

//Uncomment when authentication is implemented. Probably it will be added in other extension method
//app.UseAuthorization();

app.MapReverseProxy();

app.Run();