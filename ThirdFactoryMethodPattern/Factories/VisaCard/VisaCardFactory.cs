using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdFactoryMethodPattern.ManagerFactory;

namespace ThirdFactoryMethodPattern.Factories.VisaCard
{
    public class VisaCardFactory : ICardFactory
    {
        public ICard MakeCard()
        {
            return new VisaCard();
        }
    }
}
