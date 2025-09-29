using BuildingBlocks.ResponseUtility;
using Catalog.Api.Application.AutoMapper;
using Catalog.Api.Application.Commands;

namespace Catalog.Api.Application;

public static class ApplicationDependencyInjection
{
    public static IServiceCollection AddApplicationDependencyInjection(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(CatalogProfile));

        services.AddScoped<ICommandHandler, CommandHandler>();
        services.AddScoped<ValidationResult>();
        return services;
    } 
}