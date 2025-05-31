using LocalRestaurantApp.Domain.Entities.Base;

namespace LocalRestaurantApp.Domain.Repositories;

public interface ICommandRepository<in TEntity>
    where TEntity : BaseEntity
{
    void Add(TEntity entity);
    Task AddAsync(TEntity entity);
    void AddRange(IEnumerable<TEntity> entities);

    void Update(TEntity entity);

    void Remove(TEntity entity);
    void RemoveById(Guid id);
    void RemoveRange(IEnumerable<TEntity> entities);
}