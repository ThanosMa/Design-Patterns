using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ObserverManager
{
    internal abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private string post;

        public string Post
        {
            get { return post; }
            set 
            {   
                post = value;
                Notify();
            }
        }

        public void Subscribe(Observer observer)
        {
            observers.Add(observer);
        }
        public void Unsubscribe(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer observer in observers)
            {
                observer.Update(Post);
            }
        }
    }
}
