using Catalog.Api.Infrastructure.DAL;
using Catalog.Api.Infrastructure.Repositories.Interfaces;

namespace Catalog.Api.Infrastructure.Repositories;

public class Repository(Context Context) : IRepository
{
    public async Task AddCatalogItem()
    {
        
    }
}