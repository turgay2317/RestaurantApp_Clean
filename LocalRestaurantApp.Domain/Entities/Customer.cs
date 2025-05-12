using LocalRestaurantApp.Domain.Entities.Base;
using LocalRestaurantApp.Domain.ValueObjects;

namespace LocalRestaurantApp.Domain.Entities;

/// <summary>
/// Tekil sistem müşterisi.
/// </summary>
public sealed class Customer : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public FullAddress Address { get; set; }
    public decimal Balance { get; set; } = Decimal.Zero;
    public string FullName => $"{FirstName} {LastName}";
}