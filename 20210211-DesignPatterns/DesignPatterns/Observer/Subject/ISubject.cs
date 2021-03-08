using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface ISubject
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
        void Notify();
    }
}
