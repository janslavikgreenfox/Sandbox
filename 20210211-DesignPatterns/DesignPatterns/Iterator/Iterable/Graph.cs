using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Iterable;
using Iterator.Iterator;
using Iterator.Subject;

namespace Iterator.Iterable
{
    class Graph :  IIterable
    {
        public List<ISubject> Vertexes { get; private set; }
        public List<Tuple<ISubject,ISubject>> Edges { get; private set; }
        public Graph(List<ISubject> vertexes, List<Tuple<ISubject, ISubject>> edges)
        {
            Vertexes = vertexes;
            Edges = edges;
        }

        public IIterator GetIterator()
        {
            return new ConcreteGraphIterator(this);
        }
    }
}
