using System.Collections.Generic;
using System.Linq;


namespace MaerskCodingTestQuestion1.Repository
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>();
        }
        public string Add(Product product)
        {
            try
            {
                bool skuExists = _products.Any(x => x.Sku == product.Sku);
                if (skuExists)
                {
                    return "Duplicate entry for Sku : " + product.Sku;
                }
                else
                {
                    int nextId = _products.LastOrDefault()?.Id + 1 ?? 1;
                    product.Id = nextId;
                    _products.Add(product);
                    return "Added product with sku " + product.Sku + " successfully";
                    // _codingTestContext.SaveChanges();
                }
            }
            catch
            {
                return "Error occured while adding product with sku " + product.Sku + " successfully";
            }

        }

        public string Delete(int id)
        {
            try
            {
                Product product = _products.FirstOrDefault(x => x.Id == id);
                if (product != null)
                {
                    _products.Remove(product);
                    // _codingTestContext.SaveChanges();
                    return "Deleted product with sku " + product.Sku + " successfully";
                }
                else
                {
                    return "Product with sku " + product.Sku + " does not exists";
                }
            }
            catch            
            {
                return "Error occured while deleting product ";
            }
        }

        public Product Get(int id)
        {
            try
            {
                return _products.FirstOrDefault(x => x.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public List<Product> GetProducts()
        {
            try
            {
                return _products.ToList();
            }
            catch
            {
                return new List<Product>() ;
            }
        }

        public string Update(Product product)
        {
            try
            {
                bool skuExists = _products.Any(x => x.Sku == product.Sku);
                if (skuExists)
                {
                    

                int index = _products.FindLastIndex(x => x.Sku == product.Sku);
                _products[index] = product;
                return "Added product with sku " + product.Sku + " successfully";
                    
                }
                else
                {
                    return "Product with Sku " + product.Sku + " does not exists";
                }
            }
            catch
            {
                return "Error occured while deleting product with sku " + product.Sku;
            }

        }
    }
}
