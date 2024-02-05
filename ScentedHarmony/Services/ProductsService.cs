using ScentedHarmony.Services.DTO;
using ScentedHarmony.Services.Enums;
using ScentedHarmony.Services.MockDatabase;

namespace ScentedHarmony.Services;

public class ProductsService : IProductService
{
    private readonly IDictionary<ProductType, List<Product>> Products;
    
    public ProductsService()
    {
        Products = new Dictionary<ProductType, List<Product>>();
        foreach (var r in MockProducts.Registrations)
        {
            var rps = r.BuildUniqueProducts();
            var rpsArray = rps as Product[] ?? rps.ToArray();
            if (Products.ContainsKey(r.Category) && rpsArray.Any())
            {
                Products[r.Category].AddRange(rpsArray);
            }
            else
            {
                Products[r.Category] = [..rpsArray];
            }
        }
    }

    public IEnumerable<Product> GetAllProducts(ProductType? filter = null)
        => GetAllProducts(0, int.MaxValue, filter);

    public IEnumerable<Product> GetAllProducts(int from, int take, ProductType? filter = null)
        => (filter.HasValue
                ? Products[filter.Value]
                : Products.Values.SelectMany(p => p)).Skip((from > 0 ? from - 1 : 0) * take)
            .Take(take);
    
    public int GetAllProductsCount(ProductType? filter = null) =>
        filter.HasValue
            ? Products[filter.Value].Count
            : Products.Sum(p => p.Value.Count);
}