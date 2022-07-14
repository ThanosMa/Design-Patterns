using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.PaymentMethodStrategyManager
{
    public class DebitCardStrategy : IPaymentMethodStrategy
    {
        public bool Pay(decimal amount)
        {
            if (amount < 0m || amount > 10000)
            {
                Console.WriteLine($"Paying {amount} euros using Debit declined");
                return false;
            }
            else
            {
                Console.WriteLine($"Paying {amount} euros using Debit declined");
                return true;
            }
        }
    }
}
