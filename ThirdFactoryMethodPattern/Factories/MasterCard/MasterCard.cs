using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdFactoryMethodPattern.ManagerFactory;

namespace ThirdFactoryMethodPattern.Factories.MasterCard
{
    public class MasterCard : ICard
    {
        public void GetCardType()
        {
            Console.WriteLine("Master Card");
        }

        public void GetCreditLimit()
        {
            Console.WriteLine("35000");
        }
    }
}
