using AbstractFactoryPattern.AbstractFactoryManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.FactoryAlphabank
{
    public class AlphabankMasterCard : ICard
    {
        public void GetCardType()
        {
            Console.WriteLine("MasterCard from Alphabank");
        }

        public void GetCreditLimit()
        {
            Console.WriteLine("18000");
        }
    }
}
