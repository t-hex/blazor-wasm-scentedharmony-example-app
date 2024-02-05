using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ScentedHarmony.Services.Enums;

[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
public sealed class DisplayFilterNameAttribute : Attribute
{
    public string DisplayFilterName { get; }

    public DisplayFilterNameAttribute(string displayName)
    {
        DisplayFilterName = displayName;
    }
    
    public static string GetDisplayFilterName<TEnum>(TEnum value) where TEnum : Enum
    {
        var fieldInfo = value.GetType().GetField(value.ToString());

        if (fieldInfo == null) return value.ToString();

        var filterName = (DisplayFilterNameAttribute)fieldInfo.GetCustomAttribute<DisplayFilterNameAttribute>();

        return filterName?.DisplayFilterName ?? value.ToString();
    }
}

public enum ProductType
{
    [DisplayFilterName("Bomby do kúpeľa")]
    BathBomb,
    [DisplayFilterName("Vosky do aromalampy")]
    ScentedWax,
    [DisplayFilterName("Esenciálne spreje")]
    ScentedSpray,
    [DisplayFilterName("Mydielka")]
    Soap
}

