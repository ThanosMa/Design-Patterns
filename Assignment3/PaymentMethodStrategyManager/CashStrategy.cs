using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.PaymentMethodStrategyManager
{
    public class CashStrategy : IPaymentMethodStrategy
    {
        public bool Pay(decimal amount)
        {
            //AFM
            //Logariasmos
            //Address
            if(amount < 0|| amount > 2000m){
                Console.WriteLine($"Paying {amount} euros using Cash declined");
                return false;
            }
            else
            {
                Console.WriteLine($"Paying {amount} euros using Cash accepted");

                return true;
            }
        }
    }
}
