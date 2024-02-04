using ScentedHarmony.Services.DTO;

namespace ScentedHarmony.Services;

public class ShoppingCartService : IShoppingCartState, IShoppingCartService
{
    public int ShoppingChartProductsCount { get; private set; }
    
    public Action OnShoppingCartUpdated { get; set; }

    private readonly IDictionary<string, Order> _orders;
    
    public ShoppingCartService()
    {
        ShoppingChartProductsCount = 0;
        _orders = new Dictionary<string, Order>();
    }

    public void ClearCart()
    {
        _orders.Clear();
        ShoppingChartProductsCount = 0;
        OnShoppingCartUpdated?.Invoke();
    }
    
    public void AddOrderToShoppingCart(Order order)
    {
        var productCode = order.Product.GetUniqueCode();
        if (_orders.ContainsKey(productCode))
        {
            _orders[productCode].Amount += order.Amount;
        }
        else
        {
            _orders.Add(productCode, new Order
            {
                Amount = order.Amount,
                Product = order.Product
            });
        }

        ShoppingChartProductsCount = _orders.Keys.Count;
        OnShoppingCartUpdated.Invoke();
    }

    public void RemoveOrderFromShoppingCart(Order order)
    {
        _orders.Remove(order.Product.GetUniqueCode());
        ShoppingChartProductsCount = _orders.Keys.Count;
        OnShoppingCartUpdated.Invoke();
    }

    public IEnumerable<Order> GetAllShoppingCartOrders() => _orders.Values.Select(o => o).ToArray();
}