using LocalRestaurantApp.Application.Services.RestaurantService;
using MediatR;

namespace LocalRestaurantApp.Application.Features.CustomerFeatures.Commands.CreateCustomer;

public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
{
    private readonly ICustomerService _customerService;

    public CreateCustomerHandler(ICustomerService customerService)
    {
        _customerService = customerService;
    }
    
    public async Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
    {
        await _customerService.CreateCustomer(request);

        return new CreateCustomerResponse()
        {
            Message = "Customer created"
        };
    }
}