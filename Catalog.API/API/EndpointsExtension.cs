using Catalog.Api.API.Endpoints;

namespace Catalog.Api.API;

internal static class EndpointsExtension
{
    internal static WebApplication MapEndpoints(this WebApplication app)
    {
        CatalogGroup.Map(app);
        return app;
    }
    
}