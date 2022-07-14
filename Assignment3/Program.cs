using Assignment3.Enums;
using Assignment3.EShopContext;
using Assignment3.Models;
using Assignment3.PaymentMethodStrategyManager;
using Assignment3.VariationStrategyManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IVariationStrategy> ShopNormalVariations = new List<IVariationStrategy>()
            {
                new ColorVariationNormalStrategy(),
                new FabricVariationNormalStrategy(),
                new SizeVariationNormalStrategy()
            };
            TShirt tShirt = new TShirt(Color.BLUE, Fabric.COTTON, Size.M);
            var eShop = new EShop();
            eShop.SetPriceListVariation(ShopNormalVariations);
            var totalPrice =eShop.CalculateCost(tShirt);
            eShop.SetPaymentMethod(new VisaStrategy());
            eShop.PayTShirt(totalPrice);
        }
    }
}
