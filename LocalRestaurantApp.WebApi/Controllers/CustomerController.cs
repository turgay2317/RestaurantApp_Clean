using LocalRestaurantApp.Application.Features.CustomerFeatures.Commands.CreateCustomer;
using LocalRestaurantApp.WebApi.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LocalRestaurantApp.WebApi.Controllers;

public class CustomerController : ApiController
{
    public CustomerController(IMediator mediator) : base(mediator)
    {
        
    }
    
    [HttpPost("[action]")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateCustomer(CreateCustomerRequest request)
    {
        CreateCustomerResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}