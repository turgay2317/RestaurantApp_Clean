namespace LocalRestaurantApp.Domain.ValueObjects;

/// <summary>
/// Şehir ve ilçeye dayalı lokasyon bilgisi.
/// </summary>
public class Location
{
    public string City { get; }
    public string District { get; }
    
    private Location() { }

    public Location(string city, string district)
    {
        City = city;
        District = district;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Location other) return false;
        return City == other.City && District == other.District;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(City, District);
    }
}