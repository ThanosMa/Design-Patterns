using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdFactoryMethodPattern.ManagerFactory;

namespace ThirdFactoryMethodPattern.Factories.VisaCard
{
    public class VisaCard : ICard
    {
        public void GetCardType()
        {
            Console.WriteLine("Visa Card");
        }

        public void GetCreditLimit()
        {
            Console.WriteLine("19000");
        }
    }
}
