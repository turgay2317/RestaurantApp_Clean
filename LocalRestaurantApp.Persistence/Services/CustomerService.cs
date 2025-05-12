using LocalRestaurantApp.Application.Features.CustomerFeatures.Commands.CreateCustomer;
using LocalRestaurantApp.Application.Services.RestaurantService;
using LocalRestaurantApp.Domain.Entities;
using LocalRestaurantApp.Domain.ValueObjects;
using LocalRestaurantApp.Persistence.Context;

namespace LocalRestaurantApp.Persistence.Services;

public class CustomerService : ICustomerService
{
    private readonly AppDbContext _context;

    public CustomerService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task CreateCustomer(CreateCustomerRequest createCustomerRequest)
    {
        Customer customer = new Customer()
        {
            FirstName = createCustomerRequest.FirstName,
            LastName = createCustomerRequest.LastName,
            PhoneNumber = createCustomerRequest.PhoneNumber,
        };

        customer.Address = new FullAddress()
        {
            City = createCustomerRequest.City,
            District = createCustomerRequest.District,
            Street = createCustomerRequest.Street,
            UnitNumber = createCustomerRequest.UnitNumber,
        };
        
        await _context.Customers.AddAsync(customer);
        await _context.SaveChangesAsync();
    }
}