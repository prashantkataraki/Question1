using System;
using System.Collections.Generic;


namespace MaerskCodingTestQuestion1.Question1
{
    public static class ProgramExecuter
    {
        public static void Run()
        {
            List<ProductViewModel> products = new List<ProductViewModel>();
            Console.WriteLine("Enter the Quantity for Sku A");            
            bool isInputSuccess = Int32.TryParse(Console.ReadLine(), out int skuAQty);
            if (isInputSuccess && skuAQty >0)
            {
                ProductViewModel product = new ProductViewModel();
                product.Sku = "A";
                product.Quantity = skuAQty;
                products.Add(product);

            }
            else if(!isInputSuccess)
            {
                Console.WriteLine("Invalid Integer input. Retry..");
            }

            Console.WriteLine("Enter the Quantity for Sku B");
            isInputSuccess = Int32.TryParse(Console.ReadLine(), out int skuBQty);
            if (isInputSuccess && skuBQty > 0)
            {
                ProductViewModel product = new ProductViewModel();
                product.Sku = "B";
                product.Quantity = skuBQty;
                products.Add(product);

            }
            else if (!isInputSuccess)
            {
                Console.WriteLine("Invalid Integer input. Retry..");
            }

            Console.WriteLine("Enter the Quantity for Sku C");
            isInputSuccess = Int32.TryParse(Console.ReadLine(), out int skuCQty);
            if (isInputSuccess && skuCQty > 0)
            {
                ProductViewModel product = new ProductViewModel();
                product.Sku = "C";
                product.Quantity = skuCQty;
                products.Add(product);

            }
            else if (!isInputSuccess)
            {
                Console.WriteLine("Invalid Integer input. Retry..");
            }

            Console.WriteLine("Enter the Quantity for Sku D");
            isInputSuccess = Int32.TryParse(Console.ReadLine(), out int skuDQty);
            if (isInputSuccess && skuDQty > 0)
            {
                ProductViewModel product = new ProductViewModel(); product.Sku = "D";
                product.Quantity = skuDQty;
                products.Add(product);

            }
            else if (!isInputSuccess)
            {
                Console.WriteLine("Invalid Integer input. Retry..");
            }

            PromotionExecuter promotionExecuteManger =
                new PromotionExecuter(new PromotionManagerFactory());
            promotionExecuteManger.ApplyAllPromotions(products);
            Console.ReadLine();
        }
    }
}
