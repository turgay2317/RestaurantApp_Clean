using MediatR;

namespace LocalRestaurantApp.Application.Features.RestaurantFeatures.Commands.CreateRestaurant;

public class CreateRestaurantRequest : IRequest<CreateRestaurantResponse>
{
    public string Name { get; set; }
    public string City { get; set; }
    public string District { get; set; }
}