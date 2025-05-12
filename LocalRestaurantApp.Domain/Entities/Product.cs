using System.ComponentModel.DataAnnotations;
using LocalRestaurantApp.Domain.Entities.Base;

namespace LocalRestaurantApp.Domain.Entities;

public class Product : BaseEntity
{
    [MaxLength(50)]
    public required string Name { get; set; }
    [MaxLength(255)]
    public required string Description { get; set; }
    public required decimal Price { get; set; }
}