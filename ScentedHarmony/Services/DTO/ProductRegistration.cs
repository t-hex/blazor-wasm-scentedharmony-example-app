using ScentedHarmony.Services.Enums;

namespace ScentedHarmony.Services.DTO;

public class ProductRegistration
{
    public ProductType Category { get; init; }

    public string ProductCode { get; init; }

    public string Name { get; init; }

    public string Description { get; init; }
    
    public PackageSize[] PackageSizes { get; init; }

    public string PromoImg { get; init; }
    
    public FlavorType[] Flavors { get; init; }
}

public static class ProductRegistrationExt {
    public static IEnumerable<Product> BuildUniqueProducts(this ProductRegistration registration)
    {
        return registration.PackageSizes.SelectMany(ps => registration.Flavors
            .Select(f => new Product
            {
                Name = registration.Name,
                ProductCode = registration.ProductCode,
                Category = registration.Category,
                Description = registration.Description,
                PackageSize = ps,
                Flavor = f,
                PromoImg = registration.PromoImg
            }));
    }
}