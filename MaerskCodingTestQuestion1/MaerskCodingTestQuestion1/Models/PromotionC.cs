using System;
using System.Collections.Generic;
using System.Linq;

namespace MaerskCodingTestQuestion1.Question1
{
    internal class PromotionC : IPromotion
    {

        private readonly IProduct _product;
        public PromotionC(IProduct product)
        {
            _product = product;
        }

        internal int Apply(ProductViewModel product)
        {
            Console.WriteLine("Promotion C and D's is applied");
            return GetOfferPrice();
        }

       
        private static int GetOfferPrice()
        {
            return 30;
        }

        int IPromotion.Process(ProductViewModel product, List<ProductViewModel> products)
        {
            bool isSkuDAvailable = products.Any(x => x.Sku.ToUpperInvariant().Equals("D"));
            if (isSkuDAvailable)
                return Apply(product);
            return _product.RegularPrice();
        }

    }
    
}
