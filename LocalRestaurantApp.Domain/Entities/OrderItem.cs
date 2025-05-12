using LocalRestaurantApp.Domain.Entities.Base;

namespace LocalRestaurantApp.Domain.Entities;

public sealed class OrderItem : Creatable
{
    public required Product Product { get; set; }
    public required int Quantity { get; set; }
    public required decimal UnitPrice { get; set; }
    public required decimal TotalPrice { get; set; }
}