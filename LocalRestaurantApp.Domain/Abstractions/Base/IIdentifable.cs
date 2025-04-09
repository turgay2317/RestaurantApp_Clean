namespace LocalRestaurantApp.Domain.Abstractions.Base;

public interface IIdentifable
{
    public Guid Id { get; set; }
}