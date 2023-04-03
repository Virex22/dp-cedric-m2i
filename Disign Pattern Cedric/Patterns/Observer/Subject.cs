using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    public class Subject
    {
        protected List<Observer> observers = new List<Observer>();

        public void AddObserver(Observer observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(Observer observer) {
            this.observers.Remove(observer);
        }

        protected void Notify()
        {
            foreach (Observer observer in this.observers)
                observer.Notify();
        }
    }
}
