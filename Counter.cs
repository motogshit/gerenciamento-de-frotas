using sistemasfrotas.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasfrotas
{
    public class Counter : ISubject
    {
        private List<IObserver> _observers;
        private int _count;

        public Counter()
        {
            _observers = new List<IObserver>();
            _count = 0;
        }

        public void Increment()
        {
            _count++;
            NotifyObservers(_count);
        }
        public void Decrement()
        {
            if(_count > 0)
            {
                _count--;
                NotifyObservers(_count);
            }
        }

        public void NotifyObservers(int count)
        {
            foreach(IObserver ob in _observers)
            {
                ob.Update(count);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
