using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdFactoryMethodPattern.ManagerFactory;

namespace ThirdFactoryMethodPattern.Factories.MasterCard
{
    public class MasterCardFactory : ICardFactory
    {
        public ICard MakeCard()
        {
            //Mporoume na baloyme bussiness logic kai proipotheseis
            return new MasterCard();
        }
    }
}
