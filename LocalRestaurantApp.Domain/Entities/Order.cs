using LocalRestaurantApp.Domain.Entities.Base;

namespace LocalRestaurantApp.Domain.Entities;

/// <summary>
/// Tekil müşteri siparişi.
/// </summary>
public sealed class Order : BaseEntity
{
    /// <summary>
    /// Sipariş müşteri
    /// </summary>
    public required Customer Customer { get; set; }
    /// <summary>
    /// Sipariş ettiği sepet
    /// </summary>
    public required List<OrderItem> Items { get; set; }
}