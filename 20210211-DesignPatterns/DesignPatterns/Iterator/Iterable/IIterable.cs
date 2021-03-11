using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Iterator;

namespace Iterator.Iterable
{
    interface IIterable
    {
        IIterator GetIterator();
    }
}
