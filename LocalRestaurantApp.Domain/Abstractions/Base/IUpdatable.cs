namespace LocalRestaurantApp.Domain.Abstractions.Base;

public interface IUpdatable
{
    public DateTime? UpdatedAt { get; }
}