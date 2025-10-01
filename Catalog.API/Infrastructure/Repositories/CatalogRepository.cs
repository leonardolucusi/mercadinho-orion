using Catalog.API.Domain.Entities;
using Catalog.Api.Infrastructure.DAL;
using Catalog.Api.Infrastructure.Repositories.Interfaces;

namespace Catalog.Api.Infrastructure.Repositories;

public class CatalogRepository(Context context) : ICatalogRepository
{
    public async Task<Item> AddItem(Item item, CancellationToken cancellationToken)
    {
        await context.AddAsync(item, cancellationToken);
        return item;
    }
}