using LocalRestaurantApp.Domain.Entities.Base;
using LocalRestaurantApp.Domain.Repositories;
using LocalRestaurantApp.Persistence.Context;

namespace LocalRestaurantApp.Persistence.Repositories;

public class CommandRepository<T> : ICommandRepository<T> 
    where T : BaseEntity
{
    private readonly AppDbContext _dbContext;

    public CommandRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public void Add(T entity)
    {
        _dbContext.Add(entity);
    }

    public async Task AddAsync(T entity)
    {
        await _dbContext.AddAsync(entity);
    }

    public void AddRange(IEnumerable<T> entities)
    {
        _dbContext.AddRange(entities);
    }

    public void Update(T entity)
    {
        _dbContext.Update(entity);
    }

    public void Remove(T entity)
    {
        _dbContext.Remove(entity);
    }

    public void RemoveById(Guid id)
    {
        var entity = _dbContext.Find<T>(id);
        
        if (entity == null)
            throw new InvalidOperationException("Entity not found");
        
        _dbContext.Remove<T>(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        _dbContext.RemoveRange(entities);
    }
}