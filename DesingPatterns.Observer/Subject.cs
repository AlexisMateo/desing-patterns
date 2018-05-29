using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPatterns.Observer
{
    public abstract class Subject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver o in _observers)
            {
                o.Update();
            }
        }
    }
}
