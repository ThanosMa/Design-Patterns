using ObserverPattern.ObserverModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewsPaper newsPaper = new NewsPaper() { Title="DailyNews"};
            Reader r1 = new Reader() { name = "Thanos" };
            Reader r2 = new Reader() { name = "Fanis" };
            Reader r3 = new Reader() { name = "Lakis" };

            newsPaper.Subscribe(r1);
            newsPaper.Subscribe(r2);
            newsPaper.Subscribe(r3);

            newsPaper.Post = "Shock in Athens!";
            Console.WriteLine("----------------------------------");
            newsPaper.Post = "Famous actor lost...";
            newsPaper.Unsubscribe(r2);
            Console.WriteLine("----------------------------------");
            newsPaper.Post = "Wildfires in Europe";
        }
    }
}
