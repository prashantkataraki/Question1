using MaerskCodingTestQuestion1.Question1;
using MaerskCodingTestQuestion1.Repository;
using System.Collections.Generic;

namespace MaerskCodingTestQuestion1.Services
{
    public class ProcessOrderService : IProcessOrderService
    {
        private readonly IProductRepository _productRepository;

        public ProcessOrderService( IProductRepository productRepository)
        {     
            _productRepository = productRepository;
        }

        public List<ProductViewModel> GetAllProducts()
        {           
            List<Product> products = _productRepository.GetProducts();
            return GetProductViewModels(products);
        }

        private List<ProductViewModel> GetProductViewModels(List<Product> products)
        {
            List<ProductViewModel> productViewModels = new List<ProductViewModel>();
            foreach (Product product in products)
            {
                productViewModels.Add(new ProductViewModel()
                {
                    Quantity = product.Quantity,
                    Sku = product.Sku
                });
            }
            return productViewModels;
        }


        public string Calculatte()
        {
            List<ProductViewModel> productList = GetAllProducts();
            PromotionExecuter promotionExecuteManger =
                    new PromotionExecuter(new PromotionManagerFactory());
            return promotionExecuteManger.ApplyAllPromotions(productList);
        }

        public string Add(ProductViewModel productviewmodel)
        {
            Product product = new Product()
            {
                Quantity = productviewmodel.Quantity,
                Sku = productviewmodel.Sku
            };
            return _productRepository.Add(product);
            //return "Product added successfully.";
        }

        public string Edit(ProductViewModel productviewmodel)
        {
            Product product = new Product()
            {
                Quantity = productviewmodel.Quantity,
                Sku = productviewmodel.Sku
            };
           return _productRepository.Update(product);
            //return "Product updated successfully.";            
        }
    }
}
