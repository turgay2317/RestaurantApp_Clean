using System.Linq.Expressions;
using LocalRestaurantApp.Domain.Entities.Base;

namespace LocalRestaurantApp.Domain.Repositories;

public interface IQueryRepository<TEntity>
    where TEntity : BaseEntity
{
    IEnumerable<TEntity> GetAll();
    IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    TEntity GetFirst(Expression<Func<TEntity, bool>> predicate);
}