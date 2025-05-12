using LocalRestaurantApp.Application.Features.CustomerFeatures.Commands.CreateCustomer;

namespace LocalRestaurantApp.Application.Services.RestaurantService;

public interface ICustomerService
{
    Task CreateCustomer(CreateCustomerRequest createCustomerRequest);
}