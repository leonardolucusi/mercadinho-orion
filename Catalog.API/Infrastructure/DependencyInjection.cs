using BuildingBlocks.ResponseUtility;
using Catalog.Api.Application.Commands;

namespace Catalog.Api.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<ICommandHandler, CommandHandler>();
        services.AddScoped<ValidationResult>();

        return services;
    }
}