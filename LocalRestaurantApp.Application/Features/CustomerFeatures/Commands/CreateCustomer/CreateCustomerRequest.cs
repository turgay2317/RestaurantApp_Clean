using MediatR;

namespace LocalRestaurantApp.Application.Features.CustomerFeatures.Commands.CreateCustomer;

public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string City { get; set; }
    public string District { get; set; }
    public string Street { get; set; }
    public string UnitNumber { get; set; }
}