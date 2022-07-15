using AbstractFactoryPattern.AbstractFactoryManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.FactoryEurobank
{
    public class EurobankPaySafeCard : ICard
    {
        public void GetCardType()
        {
            Console.WriteLine("Paysafe from Eurobank");
        }

        public void GetCreditLimit()
        {
            Console.WriteLine("15000");
        }
    }
}
