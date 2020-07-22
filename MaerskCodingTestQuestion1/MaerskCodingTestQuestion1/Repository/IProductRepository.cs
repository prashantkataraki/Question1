using System.Collections.Generic;

namespace MaerskCodingTestQuestion1.Repository
{
    public interface IProductRepository
    {
        Product Get(int id);
        List<Product> GetProducts();

        string Add(Product product);
        string Update(Product product);

        string Delete(int id);
    }
}
