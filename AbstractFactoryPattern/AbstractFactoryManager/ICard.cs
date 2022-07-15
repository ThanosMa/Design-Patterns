using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactoryManager
{
    public interface ICard
    {
        void GetCardType();
        void GetCreditLimit();
    }
}
