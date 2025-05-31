namespace LocalRestaurantApp.Persistence.Repositories.Base;

using System.Linq.Expressions;
using LocalRestaurantApp.Domain.Entities.Base;
using LocalRestaurantApp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

public class QueryRepository<T> : IQueryRepository<T> 
    where T : BaseEntity
{
    private readonly DbContext _dbContext;

    public QueryRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<T> GetAll()
    {
        return _dbContext.Set<T>().ToList();
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
    {
        return _dbContext.Set<T>().Where(predicate);
    }

    public T GetFirst(Expression<Func<T, bool>> predicate)
    {
        return _dbContext.Set<T>().FirstOrDefault(predicate);
    }
}