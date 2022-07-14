using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)//High level
        {
            MasterCard card= new MasterCard();

        }


    }
    class MasterCard
    {
        public void GetCardType()
        {
            Console.WriteLine("Master Card");
        }
        public void GetCreditLimit()
        {
            Console.WriteLine("35000");
        }
    }

    class VisaCard
    {
        public void GetCardType()
        {
            Console.WriteLine("Visa Card");
        }
        public void GetCreditLimit()
        {
            Console.WriteLine("19000");
        }
    }
    class PaySafeCard
    {
        public void GetCardType()
        {
            Console.WriteLine("PaySafe Card");
        }
        public void GetCreditLimit()
        {
            Console.WriteLine("20000");
        }
    }

}
