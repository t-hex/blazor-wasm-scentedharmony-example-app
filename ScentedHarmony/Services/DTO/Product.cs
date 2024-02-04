using ScentedHarmony.Services.Enums;

namespace ScentedHarmony.Services.DTO;

public class Product
{
    public ProductType Category { get; init; }

    public string ProductCode { get; init; }

    public string Name { get; init; }

    public string Description { get; init; }
    
    public PackageSize PackageSize { get; init; }

    public string PromoImg { get; init; }
    
    public FlavorType Flavor { get; init; }

    public string GetUniqueCode() => $"{ProductCode}-{PackageSize.SizeCode}-{Flavor.FlavorCode}";
}