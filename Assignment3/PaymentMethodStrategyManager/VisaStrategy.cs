using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.PaymentMethodStrategyManager
{
    public class VisaStrategy : IPaymentMethodStrategy
    {
        public bool Pay(decimal amount)
        {
            if (amount < 0 || amount > 1500m)
            {
                Console.WriteLine($"Paying {amount} euros using Visa declined");
                return false;
            }
            else
            {
                Console.WriteLine($"Paying {amount} euros using Visa accepted");

                return true;
            }
        }
    }
}
