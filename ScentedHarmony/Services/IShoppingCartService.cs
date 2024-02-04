using ScentedHarmony.Services.DTO;

namespace ScentedHarmony.Services;

public interface IShoppingCartService
{
    public void AddOrderToShoppingCart(Order order);

    public void RemoveOrderFromShoppingCart(Order order);

    public IEnumerable<Order> GetAllShoppingCartOrders();

    public void ClearCart();
}