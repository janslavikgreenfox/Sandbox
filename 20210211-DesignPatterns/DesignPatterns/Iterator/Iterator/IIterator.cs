using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Subject;

namespace Iterator.Iterator
{
    interface IIterator
    {
        bool IsDone();
        void Next();
        ISubject GetCurrent();
    }
}
