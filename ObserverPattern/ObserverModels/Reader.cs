using ObserverPattern.ObserverManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ObserverModels
{
    internal class Reader : Observer
    {
        public string name;
        public override void Update(string postTitle)
        {
            Console.WriteLine($"Mr/Ms {name}, you have a new post: {postTitle}");
        }
    }
}
