using BuildingBlocks.ResponseUtility;
using Catalog.Api.Application.Commands;
using Catalog.Api.Infrastructure.DAL;
using Catalog.Api.Infrastructure.UOW;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Api.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<Context>(options =>
            options.UseNpgsql(configuration.GetConnectionString("ConnectionString")));
        
        services.AddScoped<ICommandHandler, CommandHandler>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ValidationResult>();

        return services;
    }
}