using BuildingBlocks.ResponseUtility;
using Catalog.Api.Application.Dtos.Command;

namespace Catalog.Api.Application.Commands;

public interface ICommandHandler
{
    public Task<Response> AddItem(ItemRegisterDto itemRegisterDto, CancellationToken cancellationToken = default);
}