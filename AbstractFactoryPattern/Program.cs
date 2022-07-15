using AbstractFactoryPattern.AbstractFactoryManager;
using AbstractFactoryPattern.FactoryAlphabank;
using AbstractFactoryPattern.FactoryEurobank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICardFactory cardFactory = new AlphabankFactory();
            ICard card= cardFactory.GetPaySafeCard();
            card.GetCardType();
            card.GetCreditLimit();

            
        }
        
    }
}
