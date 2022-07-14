using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b1 = Bank.CreateBank;
            b1.Cart.Add("Tv");
            b1.Cart.Add("Radio");

            Bank b2 = Bank.CreateBank;
            b2.Cart.Add("Fridge");
            b2.Cart.Add("Oven");

            foreach (var item in b2.Cart)
            {
                Console.WriteLine(item);
            }
            
        }
    }

    sealed class Bank
    {
        public string Name { get; set; } = "Eurobank";
        public List<string> Cart { get; set; } = new List<string>();

        //Singleton Design Pattern
        //private static object lockObject= new object();
        public static Bank CreateBank { get; } = new Bank();
        private Bank()
        {
            Console.WriteLine("Eimai o Constructor");
        }
        

       
    }
}
