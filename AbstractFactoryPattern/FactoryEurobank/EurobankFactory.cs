using AbstractFactoryPattern.AbstractFactoryManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.FactoryEurobank
{
    public class EurobankFactory : ICardFactory
    {
        public ICard GetMasterCard()
        {
            return new EurobankMasterCard();
        }

        public ICard GetPaySafeCard()
        {
            return new EurobankPaySafeCard();
        }

        public ICard GetVisaCard()
        {
            return new EurobankVisaCard();
        }
    }
}
