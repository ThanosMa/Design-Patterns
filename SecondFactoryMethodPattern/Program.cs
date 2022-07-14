using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondFactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICard card = Factory.Create(Card.VisaCard);
            card.GetCardType();
            card.GetCreditLimit();
        }
    }
    enum Card
    {
        MasterCard,
        VisaCard,
        PaySafeCard
    }

    class Factory
    {
        public static ICard Create(Card choice)
        {
            switch (choice)
            {
                case Card.MasterCard: return new MasterCard();
                case Card.VisaCard: return new VisaCard();
                case Card.PaySafeCard: return new PaySafeCard();
                    default:return null;
            }
        }
    }

    interface ICard
    {
        void GetCardType();
        void GetCreditLimit();
    }
    class MasterCard: ICard
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

    class VisaCard: ICard
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
    class PaySafeCard: ICard
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
