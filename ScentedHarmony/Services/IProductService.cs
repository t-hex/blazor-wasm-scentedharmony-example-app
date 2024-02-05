using ScentedHarmony.Services.DTO;
using ScentedHarmony.Services.Enums;

namespace ScentedHarmony.Services;

public interface IProductService
{
    public IEnumerable<Product> GetAllProducts(ProductType? filter = null);

    public IEnumerable<Product> GetAllProducts(int from, int take, ProductType? filter = null);

    public int GetAllProductsCount(ProductType? filter = null);
}