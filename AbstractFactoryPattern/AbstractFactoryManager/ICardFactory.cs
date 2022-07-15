using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactoryManager
{
    public interface ICardFactory
    {
        ICard GetMasterCard();
        ICard GetVisaCard();
        ICard GetPaySafeCard();
    }
}
