namespace ScentedHarmony.Services;

public interface IShoppingCartState
{
    public int ShoppingChartProductsCount { get; }
    
    public Action OnShoppingCartUpdated { get; set; }
}