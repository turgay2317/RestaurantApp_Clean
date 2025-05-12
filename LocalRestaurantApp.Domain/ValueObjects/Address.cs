namespace LocalRestaurantApp.Domain.ValueObjects;

/// <summary>
/// Şehir ve ilçeye dayalı lokasyon bilgisi.
/// </summary>
public class Address
{
    public string City { get; set; }
    public string District { get; set; }
    
    private Address() { }

    public Address(string city, string district)
    {
        City = city;
        District = district;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Address other) return false;
        return City == other.City && District == other.District;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(City, District);
    }
}