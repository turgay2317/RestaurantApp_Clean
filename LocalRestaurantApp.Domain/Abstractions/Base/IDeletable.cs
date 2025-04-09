namespace LocalRestaurantApp.Domain.Abstractions.Base;

public interface IDeletable
{
    public DateTime? DeletedOn { get; set; }
}