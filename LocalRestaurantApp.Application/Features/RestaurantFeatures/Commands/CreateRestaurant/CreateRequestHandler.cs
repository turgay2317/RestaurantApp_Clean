using MediatR;
using LocalRestaurantApp.Application.Services.RestaurantService;

namespace LocalRestaurantApp.Application.Features.RestaurantFeatures.Commands.CreateRestaurant;

public class CreateRequestHandler : IRequestHandler<CreateRestaurantRequest, CreateRestaurantResponse>
{
    private readonly IRestaurantService _restaurantService;

    public CreateRequestHandler(IRestaurantService restaurantService)
    {
        _restaurantService = restaurantService;
    }
    
    public async Task<CreateRestaurantResponse> Handle(CreateRestaurantRequest request, CancellationToken cancellationToken)
    {
        await _restaurantService.CreateRestaurant(request);
        return new CreateRestaurantResponse()
        {
            Message = "Restaurant created successfully.",
        };
    }
}