using LocalRestaurantApp.Domain.Entities;
using LocalRestaurantApp.Domain.Entities.Base;
using LocalRestaurantApp.Domain.Entities.Identity;
using LocalRestaurantApp.Domain.Enums;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LocalRestaurantApp.Persistence.Context;

public sealed class AppDbContext : IdentityDbContext<User, Role, string>
{
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<RestaurantUserRelationship> RestaurantUserRelationships { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.Entity<Restaurant>()
            .OwnsOne(c => c.Address);
        
        builder.Entity<Customer>()
            .OwnsOne(c => c.Address);
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entries = ChangeTracker.Entries();
        
        foreach (var entry in entries)
        {
            if (entry.Entity is Creatable && entry.State == EntityState.Added)
            {
                entry.Property(nameof(Creatable.CreatedAt)).CurrentValue = DateTime.UtcNow;
            }
            
            // Güncellenebilen veri
            if (entry.Entity is Updatable)
            {
                // Güncellenirse
                if (entry.State == EntityState.Modified)
                {
                    entry.Property(nameof(Updatable.UpdatedAt)).CurrentValue = DateTime.Now;
                }
                // Oluşturulursa
                if (entry.State == EntityState.Added)
                {
                    entry.Property(nameof(Updatable.Status)).CurrentValue = Status.Active;
                }
            }

            if (entry.Entity is Deletable && entry.State == EntityState.Deleted)
            {
                entry.Property(nameof(Deletable.DeletedOn)).CurrentValue = DateTime.Now;
                entry.Property(nameof(Deletable.Status)).CurrentValue = Status.Deleted;
            }
        }
        
        return base.SaveChangesAsync(cancellationToken);
    }
}