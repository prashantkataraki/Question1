using System.Collections.Generic;

namespace MaerskCodingTestQuestion1.Question1
{
    internal class PromotionExecuter
    {
        private IPromotion _promotion;
        private PromotionManagerFactory _promotionManager;

        public PromotionExecuter(PromotionManagerFactory promotionManager)
        {
            _promotionManager = promotionManager;
        }

        internal string ApplyAllPromotions(List<ProductViewModel> products)
        {
            int totalCost = 0;
            foreach(ProductViewModel product in products)
            {
                _promotion = _promotionManager.GetManager(product.Sku);
                totalCost += _promotion?.Process(product, products) ?? 0;
            }

            return "Total cost above selected products is : $" + totalCost.ToString();

        }
    }
}
