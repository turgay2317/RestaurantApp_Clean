using LocalRestaurantApp.Application.Features.RestaurantFeatures.Commands.CreateRestaurant;
using LocalRestaurantApp.Application.Services.RestaurantService;
using LocalRestaurantApp.Domain.Entities;
using LocalRestaurantApp.Domain.ValueObjects;
using LocalRestaurantApp.Persistence.Context;

namespace LocalRestaurantApp.Persistence.Services;

public class RestaurantService : IRestaurantService
{
    private readonly AppDbContext _context;

    public RestaurantService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task CreateRestaurant(CreateRestaurantRequest createRestaurantRequest)
    {
        Restaurant restaurant = new Restaurant();
        restaurant.Name = createRestaurantRequest.Name;
        restaurant.Address = new Address(createRestaurantRequest.City, createRestaurantRequest.District);
        await _context.Restaurants.AddAsync(restaurant);
        await _context.SaveChangesAsync();
    }
}