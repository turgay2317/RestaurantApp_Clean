using LocalRestaurantApp.Domain.Entities.Base;
using LocalRestaurantApp.Domain.Entities.Identity;

namespace LocalRestaurantApp.Domain.Entities;

/// <summary>
/// Restorant-Üye ilişkisi
/// </summary>
public class RestaurantUserRelationship : Identifable
{
    public required Guid RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
    
    public required string UserId { get; set; }
    public User User { get; set; }
}