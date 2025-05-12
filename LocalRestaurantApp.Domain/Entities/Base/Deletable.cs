using LocalRestaurantApp.Domain.Abstractions.Base;

namespace LocalRestaurantApp.Domain.Entities.Base;

/// <summary>
/// Silinebilen nesne.
/// </summary>
public class Deletable : Updatable, IDeletable
{
    public DateTime? DeletedOn { get; set; }
}