using ScentedHarmony.Services.DTO;
using ScentedHarmony.Services.Enums;

namespace ScentedHarmony.Services.MockDatabase;

public static class MockProducts
{
    public static IReadOnlyCollection<ProductRegistration> Registrations = new[]
    {
        new ProductRegistration
        {
            Name = "Bomby do kúpeľa (1ks)",
            Description = "Relaxačné bomby pre aféru vody",
            Category = ProductType.BathBomb,
            PackageSizes = [
                new PackageSize { Price = 2.20f, SizeDescriptor = "S/85g", SizeCode = "S85G", Size = 85.0f },
                new PackageSize { Price = 3.30f, SizeDescriptor = "M/120g", SizeCode = "M120G", Size = 120.0f },
                new PackageSize { Price = 4.20f, SizeDescriptor = "L/145g", SizeCode = "L145G", Size = 145.0f  },
            ],
            Flavors = [
                new FlavorType { FlavorDescriptor = "Levanduľa", FlavorCode = "L" },
                new FlavorType { FlavorDescriptor = "Citrón", FlavorCode = "C" },
                new FlavorType() { FlavorDescriptor = "Jahoda", FlavorCode = "J" },
                new FlavorType() { FlavorDescriptor = "Kokos", FlavorCode = "K" },
                new FlavorType() { FlavorDescriptor = "Ruža", FlavorCode = "R" }
            ],
            ProductCode = "BS1KS",
            PromoImg = "1ksbathbomb.jpg"
        },
        new ProductRegistration
        {
            Name = "Bomby do kúpeľa (5ks)",
            Description = "Relaxačné bomby pre aféru vody",
            Category = ProductType.BathBomb,
            PackageSizes = [
                new PackageSize { Price = 2.20f, SizeDescriptor = "S/85g", SizeCode = "S85G", Size = 85.0f },
                new PackageSize { Price = 3.30f, SizeDescriptor = "M/120g", SizeCode = "M120G", Size = 120.0f },
                new PackageSize { Price = 4.20f, SizeDescriptor = "L/145g", SizeCode = "L145G", Size = 145.0f  },
            ],
            Flavors = [
                new FlavorType { FlavorDescriptor = "Levanduľa", FlavorCode = "L" },
                new FlavorType { FlavorDescriptor = "Citrón", FlavorCode = "C" },
                new FlavorType { FlavorDescriptor = "Jahoda", FlavorCode = "J" },
                new FlavorType { FlavorDescriptor = "Kokos", FlavorCode = "K" },
                new FlavorType { FlavorDescriptor = "Ruža", FlavorCode = "R" }
            ],
            ProductCode = "BS5KS",
            PromoImg = "5ksbathbomb.jpg"
        },
        new ProductRegistration
        {
            Name = "Vonný vosk do aromalampy",
            Description = "Zlepšenie atmosféri s vonkami pre Váš večer",
            Category = ProductType.ScentedWax,
            PackageSizes = [
                new PackageSize { Price = 1.50f, SizeDescriptor = "S/18g", SizeCode = "S18G", Size = 18.0f },
                new PackageSize { Price = 2.10f, SizeDescriptor = "M/22g", SizeCode = "M22G", Size = 22.0f },
                new PackageSize { Price = 2.70f, SizeDescriptor = "L/30g", SizeCode = "L30G", Size = 30.0f  },
            ],
            Flavors = [
                new FlavorType { FlavorDescriptor = "Levanduľa", FlavorCode = "L" },
                new FlavorType { FlavorDescriptor = "Citrus", FlavorCode = "C" },
                new FlavorType { FlavorDescriptor = "Jahoda", FlavorCode = "J" },
                new FlavorType { FlavorDescriptor = "Kokos", FlavorCode = "K" },
                new FlavorType { FlavorDescriptor = "Ruža", FlavorCode = "R" },
                new FlavorType { FlavorDescriptor = "Jablko", FlavorCode = "B" }
            ],
            ProductCode = "SW",
            PromoImg = "scentedwax.jpg"
        },
        new ProductRegistration
        {
            Name = "Esenciálny sprej",
            Description = "Vyrábané z esenciálnych olejov a naturálnych zložiek, produkt s vynikajúcim liečivým kúzlom",
            Category = ProductType.ScentedSpray,
            PackageSizes = [
                new PackageSize { Price = 7.99f, SizeDescriptor = "S/100ml", SizeCode = "M100ML", Size = 100.0f, SizeUnit = "ml" },
                new PackageSize { Price = 11.99f, SizeDescriptor = "M/150ml", SizeCode = "M150ML", Size = 150.0f, SizeUnit = "ml" },
                new PackageSize { Price = 15.50f, SizeDescriptor = "L/250ml", SizeCode = "M250ML", Size = 250.0f, SizeUnit = "ml"  },
            ],
            Flavors = [
                new FlavorType { FlavorDescriptor = "Levanduľa", FlavorCode = "L" },
                new FlavorType { FlavorDescriptor = "Citrón", FlavorCode = "C" },
                new FlavorType { FlavorDescriptor = "Eukalyptus", FlavorCode = "E" },
                new FlavorType { FlavorDescriptor = "Mäta", FlavorCode = "M" },
                new FlavorType { FlavorDescriptor = "Pomaranč", FlavorCode = "P" },
                new FlavorType { FlavorDescriptor = "Škorica", FlavorCode = "S" }
            ],
            ProductCode = "SS",
            PromoImg = "scentedspray.jpg"
        },
        new ProductRegistration
        {
            Name = "Mydielko (srdce)",
            Description = "Mydielka pre hladkú pokožku a pre arómu kúpeľa.",
            Category = ProductType.Soap,
            PackageSizes = [
                new PackageSize { Price = 5.50f, SizeDescriptor = "100g", SizeCode = "100G", Size = 100.0f },
            ],
            Flavors = [
                new FlavorType { FlavorDescriptor = "Levanduľa", FlavorCode = "L" },
                new FlavorType { FlavorDescriptor = "Fialka", FlavorCode = "F" },
                new FlavorType { FlavorDescriptor = "Aloe Vera", FlavorCode = "A" },
                new FlavorType { FlavorDescriptor = "Melón", FlavorCode = "M" },
                new FlavorType { FlavorDescriptor = "Kiwi", FlavorCode = "K" },
                new FlavorType { FlavorDescriptor = "Ruža", FlavorCode = "R" }
            ],
            ProductCode = "SH",
            PromoImg = "soaphearth.png"
        },
        new ProductRegistration
        {
            Name = "Mydielko (sada)",
            Description = "Mydielka pre hladkú pokožku a pre arómu kúpeľa.",
            Category = ProductType.Soap,
            PackageSizes = [
                new PackageSize { Price = 16.50f, SizeDescriptor = "500g", SizeCode = "500G", Size = 500.0f },
            ],
            Flavors = [
                new FlavorType { FlavorDescriptor = "Levanduľa", FlavorCode = "L" },
                new FlavorType { FlavorDescriptor = "Fialka", FlavorCode = "F" },
                new FlavorType { FlavorDescriptor = "Aloe Vera", FlavorCode = "A" },
                new FlavorType { FlavorDescriptor = "Melón", FlavorCode = "M" },
                new FlavorType { FlavorDescriptor = "Kiwi", FlavorCode = "K" },
                new FlavorType { FlavorDescriptor = "Ruža", FlavorCode = "R" }
            ],
            ProductCode = "SC",
            PromoImg = "soapcombo.png"
        },
    };
}