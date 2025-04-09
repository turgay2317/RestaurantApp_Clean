using LocalRestaurantApp.Domain.Entities.Base;
using LocalRestaurantApp.Domain.ValueObjects;

namespace LocalRestaurantApp.Domain.Entities;

/// <summary>
/// Sistemde yer alan restorant.
/// </summary>
public class Restaurant : Updatable
{
    public string Name { get; set; }
    public Location Location { get; set; }
}