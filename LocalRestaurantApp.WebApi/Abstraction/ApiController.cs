using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LocalRestaurantApp.WebApi.Abstraction;

[ApiController]
[Route("api/[controller]")]
public class ApiController : ControllerBase
{
    protected readonly IMediator _mediator;
    
    protected ApiController(IMediator mediator)
    {
        _mediator = mediator;
    }
}