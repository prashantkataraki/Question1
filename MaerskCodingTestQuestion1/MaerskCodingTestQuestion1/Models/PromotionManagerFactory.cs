
namespace MaerskCodingTestQuestion1.Question1
{
    internal class PromotionManagerFactory
    {
        internal IPromotion GetManager(string sku)
        {
            IPromotion promotion = null;
            switch (sku.ToUpper())
            {
                case "A":
                    promotion = new PromotionA(new A());
                    break;
                case "B":
                    promotion = new PromotionB(new B());
                    break;
                case "C":
                    promotion = new PromotionC(new C());
                    break;
                case "D":
                    promotion = new PromotionD(new D());
                    break;
                default:
                    break;
            }
            return promotion;
        }
    }
}
