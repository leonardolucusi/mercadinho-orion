using BuildingBlocks.ResponseUtility;
using Catalog.Api.Application.Dtos.Common;

namespace Catalog.Api.Application.Commands;

public interface ICommandHandler
{
    public Task<Response> AddItem(ItemCadastrarDto itemCadastrarDto, CancellationToken cancellationToken = default);
}