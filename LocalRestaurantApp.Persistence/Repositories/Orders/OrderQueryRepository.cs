using LocalRestaurantApp.Domain.Entities;
using LocalRestaurantApp.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace LocalRestaurantApp.Persistence.Repositories.Orders;

public class OrderQueryRepository : QueryRepository<Order>
{
    private readonly DbContext _dbContext;
    
    public OrderQueryRepository(DbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
}