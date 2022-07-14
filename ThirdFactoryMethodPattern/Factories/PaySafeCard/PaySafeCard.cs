using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdFactoryMethodPattern.ManagerFactory;

namespace ThirdFactoryMethodPattern.Factories.PaySafeCard
{
    public class PaySafeCard : ICard
    {
        public void GetCardType()
        {
            Console.WriteLine("PaySafe Card");
        }

        public void GetCreditLimit()
        {
            Console.WriteLine("20000");
        }
    }
}
