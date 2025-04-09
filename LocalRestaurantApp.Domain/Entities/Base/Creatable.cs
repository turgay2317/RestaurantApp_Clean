using LocalRestaurantApp.Domain.Abstractions.Base;

namespace LocalRestaurantApp.Domain.Entities.Base;

/// <summary>
/// Oluşturulabilen nesne.
/// </summary>
public class Creatable : Identifable, ICreatable
{
    public DateTime CreatedAt { get; set; }
}