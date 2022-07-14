using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdFactoryMethodPattern.Factories.MasterCard;
using ThirdFactoryMethodPattern.ManagerFactory;

namespace ThirdFactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICard card =new MasterCardFactory().MakeCard();
            card.GetCardType();
            card.GetCreditLimit();
        }
    }
}
