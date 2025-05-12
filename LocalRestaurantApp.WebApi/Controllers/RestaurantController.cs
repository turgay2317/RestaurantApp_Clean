using Microsoft.AspNetCore.Mvc;
using LocalRestaurantApp.Application.Features.RestaurantFeatures.Commands.CreateRestaurant;
using LocalRestaurantApp.WebApi.Abstraction;
using MediatR;

namespace LocalRestaurantApp.WebApi.Controllers;

public class RestaurantController : ApiController
{
    public RestaurantController(IMediator mediator) : base(mediator)
    {
        
    }
    
    [HttpPost("[action]")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateRestaurant(CreateRestaurantRequest request)
    {
        CreateRestaurantResponse response = await _mediator.Send(request);
        return Ok(response);
    }
    
}