using BuildingBlocks.ResponseUtility;
using Catalog.Api.Application.Commands;
using Catalog.Api.Application.Dtos.Common;

namespace Catalog.Api.API.Endpoints;

internal partial class CatalogGroup
{
    private static async Task<Response> CadastrarItem(
        ICommandHandler commandHandler,
        ItemCadastrarDto content,
        CancellationToken cancellationToken
    )
    {
        var response = await commandHandler.AddItem(content, cancellationToken);
        return response;
    } 
}