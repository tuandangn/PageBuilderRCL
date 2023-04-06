using PageBuilderRCL.Domain.Shared;

namespace PageBuilderRCL.Data.MongoDb;

public sealed class PageBuilderRclMongoRepository<TEntity> : IPageBuilderRclRepository<TEntity> where TEntity : PageBuilderRclAggregateEntity
{
    private readonly IPageBuilderRclDbContext _dbContext;

    public PageBuilderRclMongoRepository(IPageBuilderRclDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        if (entity is null)
            throw new ArgumentNullException(nameof(entity));

        return _dbContext.RemoveAsync(entity, cancellationToken);
    }

    public Task<IEnumerable<TEntity>> GetAllAsync()
        => _dbContext.GetDataAsync<TEntity>();

    public Task<TEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        => _dbContext.FindAsync<TEntity>(id, cancellationToken);

    public Task<TEntity> InsertAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        if (entity is null)
            throw new ArgumentNullException(nameof(entity));

        return _dbContext.AddAsync(entity, cancellationToken);
    }

    public Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        if (entity is null)
            throw new ArgumentNullException(nameof(entity));

        return _dbContext.UpdateAsync(entity, cancellationToken);
    }
}