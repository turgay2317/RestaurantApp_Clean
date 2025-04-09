using LocalRestaurantApp.Domain.Enums;

namespace LocalRestaurantApp.Domain.Abstractions.Base;

public interface IStatus
{
    Status Status { get; }
    void ChangeStatus(Status status);
}