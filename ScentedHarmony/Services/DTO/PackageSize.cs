namespace ScentedHarmony.Services.DTO;

public class PackageSize
{
    public float Price { get; init; }
    
    public string SizeDescriptor { get; init; }

    public float? Size { get; init; } = null;
    
    public string SizeUnit { get; init; } = "g";
    
    public string SizeCode { get; init; }
}