using BuildingBlocks.ResponseUtility;
using Catalog.Api.Application.Commands;
using Catalog.Api.Application.Dtos.Command;

namespace Catalog.Api.API.Endpoints;

internal partial class CatalogGroup
{
    private static async Task<Response> CadastrarItem(
        ICommandHandler commandHandler,
        ItemRegisterDto content,
        CancellationToken cancellationToken
    )
    {
        var response = await commandHandler.AddItem(content, cancellationToken);
        return response;
    } 
}