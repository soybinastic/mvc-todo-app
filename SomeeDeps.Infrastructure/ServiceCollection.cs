using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SomeeDeps.Infrastructure.Data;

namespace SomeeDeps.Infrastructure;

public static class ServiceCollection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<SomeeDepsContext>(
            option => option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
        );
        return services;
    }
}