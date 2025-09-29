using Catalog.Api.Infrastructure.DAL;
using Catalog.Api.Infrastructure.Repositories;
using Catalog.Api.Infrastructure.Repositories.Interfaces;
using Catalog.Api.Infrastructure.UOW;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Api.Infrastructure;

public static class InfrastructureDependencyInjection
{
    public static IServiceCollection AddInfrastructureDependencyInjection(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<Context>(options =>
            options.UseNpgsql(configuration.GetConnectionString("ConnectionString")));
        
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}