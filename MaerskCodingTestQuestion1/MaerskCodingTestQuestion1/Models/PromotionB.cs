using System;
using System.Collections.Generic;

namespace MaerskCodingTestQuestion1.Question1
{
    internal class PromotionB : IPromotion
    {
        private readonly IProduct _product;
        public PromotionB(IProduct product)
        {
            _product = product;
        }
        internal int Apply(ProductViewModel product)
        {
            if (product.Quantity >= 2 && product.Sku.ToUpperInvariant().Equals("B"))
            {
                product.Quantity -= 2;
                product.TotalCost += GetOfferPrice();
                Console.WriteLine("Promotion 2 of B's is applied");
                Apply(product);
            }
            else
            {
                while (product.Quantity > 0)
                {
                    product.TotalCost += _product.RegularPrice();
                    product.Quantity--;
                }
                product.IsPromotionApplied = true;                
            }
            return product.TotalCost;
        }
 
        private static int GetOfferPrice()
        {
            return 45;
        }

        int IPromotion.Process(ProductViewModel product,List<ProductViewModel> products)
        {
            return Apply(product);
        }
    }
}
