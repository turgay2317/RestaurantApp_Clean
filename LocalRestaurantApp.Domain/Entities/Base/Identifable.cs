using LocalRestaurantApp.Domain.Abstractions.Base;

namespace LocalRestaurantApp.Domain.Entities.Base;

/// <summary>
/// Benzersiz tanımlanabilen nesne.
/// </summary>
public class Identifable : IIdentifable
{
    public Guid Id { get; set; } = Guid.NewGuid();
}