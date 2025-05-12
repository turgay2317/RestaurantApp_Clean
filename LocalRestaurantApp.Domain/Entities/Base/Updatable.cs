using LocalRestaurantApp.Domain.Abstractions.Base;
using LocalRestaurantApp.Domain.Enums;

namespace LocalRestaurantApp.Domain.Entities.Base;

/// <summary>
/// Güncellenebilen nesne.
/// </summary>
public class Updatable : Creatable, IUpdatable, IStatus
{
    public Status Status { get; set; }
    public DateTime? UpdatedAt { get; set; }
    
    public void ChangeStatus(Status status) => Status = status;
}