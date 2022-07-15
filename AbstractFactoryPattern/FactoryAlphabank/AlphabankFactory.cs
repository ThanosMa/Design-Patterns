using AbstractFactoryPattern.AbstractFactoryManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.FactoryAlphabank
{
    public class AlphabankFactory : ICardFactory
    {
        public ICard GetMasterCard()
        {
            return new AlphabankMasterCard();
        }

        public ICard GetPaySafeCard()
        {
            return new AlphabankPaySafeCard();
        }

        public ICard GetVisaCard()
        {
            return new AlphabankVisaCard();
        }
    }
}
