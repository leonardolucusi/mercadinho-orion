namespace Catalog.Api.API.Endpoints;

internal static partial class CatalogGroup
{
    internal static void Map(WebApplication app)
    {
        app.MapPost("/api/v1/catalog/item", CadastrarItem)
            .AllowAnonymous();
    }
}