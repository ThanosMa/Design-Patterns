using Assignment3.Enums;
using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.VariationStrategyManager
{
    public class SizeVariationNormalStrategy:IVariationStrategy
    {
        private static Dictionary<Size, decimal> sizePriceList;
        static SizeVariationNormalStrategy()
        {
            sizePriceList = new Dictionary<Size, decimal>()
            {
                {Size.XS,2m },
                {Size.S,3m },
                {Size.M,4m},
                {Size.L,5m },
                {Size.XL,6m },
                {Size.XXL,7m },
                {Size.XXXL,8m },
            };
        }
        public void Cost(TShirt tShirt)
        {
            tShirt.Price += sizePriceList[tShirt.Size]; //Dictionary me Keys,Values
        }
    }
}
