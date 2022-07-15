using AbstractFactoryPattern.AbstractFactoryManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.FactoryAlphabank
{
    public class AlphabankPaySafeCard : ICard
    {
        public void GetCardType()
        {
            Console.WriteLine("PaySafe from Alphabank");
        }

        public void GetCreditLimit()
        {
            Console.WriteLine("14000");
        }
    }
}
