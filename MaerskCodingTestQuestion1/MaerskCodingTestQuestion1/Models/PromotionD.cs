using System;
using System.Collections.Generic;
using System.Linq;


namespace MaerskCodingTestQuestion1.Question1
{
    internal class PromotionD : IPromotion
    {
        private readonly IProduct _product;
        public PromotionD(IProduct product)
        {
            _product = product;
        }

        internal int Apply(ProductViewModel product)
        {
            Console.WriteLine("Promotion C and D is already applied once");
            return OfferPrice();
        }


        private static int OfferPrice()
        {
            return 0;
        }

        int IPromotion.Process(ProductViewModel product, List<ProductViewModel> products)
        {
            bool isSkuDAvailable = products.Any(x => x.Sku.ToUpperInvariant().Equals("C"));
            if (isSkuDAvailable)
                return Apply(product);
            return _product.RegularPrice();
        }

    }
}
