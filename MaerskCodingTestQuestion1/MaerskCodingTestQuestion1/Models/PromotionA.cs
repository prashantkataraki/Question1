using System;
using System.Collections.Generic;

namespace MaerskCodingTestQuestion1.Question1
{
    internal class PromotionA : IPromotion
    {
        private readonly IProduct _product;
        public PromotionA(IProduct product)
        {
            _product = product;
        } 

        private int OfferPrice()
        {
            return 130;
        }

        private int Apply(ProductViewModel product)
        {
            if (product.Quantity >= 3 && product.Sku.ToUpperInvariant().Equals("A"))
            {
                product.Quantity -= 3;
                product.TotalCost += OfferPrice();
                Console.WriteLine("Promotion 3 of As applied..");
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


      

        int IPromotion.Process(ProductViewModel product, List<ProductViewModel> products)
        {
            return Apply(product);
        }
    }
}
