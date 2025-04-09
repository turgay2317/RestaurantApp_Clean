using LocalRestaurantApp.Application.Features.RestaurantFeatures.Commands.CreateRestaurant;

namespace LocalRestaurantApp.Application.Services.RestaurantService;

public interface IRestaurantService
{
    Task CreateRestaurant(CreateRestaurantRequest createRestaurantRequest);
}