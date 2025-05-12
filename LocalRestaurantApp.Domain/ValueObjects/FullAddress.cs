namespace LocalRestaurantApp.Domain.ValueObjects;

/// <summary>
/// Şehir, ilçe, mahalle, numaraya dayalı lokasyon bilgisi.
/// </summary>
public sealed class FullAddress : Address
{
    public string Street { get; set; }
    public string UnitNumber { get; set; }
    
    public FullAddress() : base(null, null)
    {

    }
    
    public override bool Equals(object? obj)
    {
        if (obj is not FullAddress other) return false;
        return City == other.City && 
               District == other.District && 
               Street == other.Street && 
               UnitNumber == other.UnitNumber;
    }
    
}