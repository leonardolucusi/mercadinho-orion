using System.Linq.Expressions;
using Catalog.Api.Infrastructure.DAL;
using Catalog.Api.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Api.Infrastructure.Repositories;

public class Repository<TEntity>(Context context) : IRepository<TEntity> where TEntity : class
{
    private readonly DbSet<TEntity> _dbSet = context.Set<TEntity>();
    
    public async Task<IQueryable<TEntity>> Search(
        Expression<Func<TEntity, bool>> predicate,
        bool @readonly = true,
        CancellationToken cancellationToken = default,
        params Expression<Func<TEntity, object>>[] includeProperties) =>
        await Task.Run(() =>
        {
            var queryableResultWithIncludes = includeProperties
                .Aggregate(_dbSet.AsQueryable(), (current, include) => current.Include(include));
            return @readonly
                ? queryableResultWithIncludes.Where(predicate).AsNoTracking()
                : queryableResultWithIncludes.Where(predicate);
        }, cancellationToken);
}