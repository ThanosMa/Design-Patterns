using Assignment3.Models;
using Assignment3.PaymentMethodStrategyManager;
using Assignment3.VariationStrategyManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.EShopContext
{
    sealed class EShop
    {
        //public static readonly EShop eShop = new EShop();
        //private EShop()
        //{

        //}

        private IEnumerable<IVariationStrategy> variationPriceListStrategies;
        private IPaymentMethodStrategy paymentMethodStrategy;
        
        public void SetPriceListVariation(IEnumerable<IVariationStrategy> strategies)
        {
            variationPriceListStrategies = strategies;
        }

        public void SetPaymentMethod(IPaymentMethodStrategy method)
        {
            paymentMethodStrategy = method;
        }

        public decimal CalculateCost(TShirt tShirt)
        {
            foreach (var strat in variationPriceListStrategies)
            {
                strat.Cost(tShirt);
            }
            Console.WriteLine($"T-Shirt final price: {tShirt.Price} euros.");
            return tShirt.Price;
        }

        public void PayTShirt(decimal price)
        {
            if (paymentMethodStrategy.Pay(price))
            {
                Console.WriteLine("Transaction Successfull");
            }
            else
            {
                Console.WriteLine("Transaction Successfull");
            }
        }
        //Singleton an thelw
    }
}
