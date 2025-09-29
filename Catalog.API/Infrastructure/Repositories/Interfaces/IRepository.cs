using System.Linq.Expressions;

namespace Catalog.Api.Infrastructure.Repositories.Interfaces;

public interface IRepository<TEntity> where TEntity : class
{
    public Task<IQueryable<TEntity>> Search(
        Expression<Func<TEntity, bool>> predicate,
        bool @readonly = true,
        CancellationToken cancellationToken = default,
        params Expression<Func<TEntity, object>>[] includeProperties);
}