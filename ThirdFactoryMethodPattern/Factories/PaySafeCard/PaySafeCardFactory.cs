using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdFactoryMethodPattern.ManagerFactory;

namespace ThirdFactoryMethodPattern.Factories.PaySafeCard
{
    public class PaySafeCardFactory : ICardFactory
    {
        public ICard MakeCard()
        {
            return new PaySafeCard();
        }
    }
}
