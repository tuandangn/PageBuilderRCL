using PageBuilderRCL.Domain.Shared;

namespace PageBuilderRCL.Data;

public interface IPageBuilderRclDbContext
{
    IQueryable<TEntity> GetDataSource<TEntity>() where TEntity : PageBuilderRclAggregateEntity;

    Task<IEnumerable<TEntity>> GetDataAsync<TEntity>() where TEntity : PageBuilderRclAggregateEntity;

    Task<TEntity?> FindAsync<TEntity>(Guid key, CancellationToken cancellationToken = default)
        where TEntity : PageBuilderRclAggregateEntity;

    Task<TEntity> AddAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default)
        where TEntity : PageBuilderRclAggregateEntity;

    Task RemoveAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default) where TEntity : PageBuilderRclAggregateEntity;

    Task<TEntity> UpdateAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default)
             where TEntity : PageBuilderRclAggregateEntity;
}