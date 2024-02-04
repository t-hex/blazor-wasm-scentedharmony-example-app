using ScentedHarmony.Services.DTO;

namespace ScentedHarmony.Services;

public interface IProductService
{
    public IEnumerable<Product> GetAllProducts();

    public IEnumerable<Product> GetAllProducts(int from, int take);

    public int GetAllProductsCount();
}