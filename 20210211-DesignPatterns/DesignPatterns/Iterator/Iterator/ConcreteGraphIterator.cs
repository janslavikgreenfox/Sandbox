using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iterator.Iterable;
using Iterator.Subject;

namespace Iterator.Iterator
{
    class ConcreteGraphIterator : IIterator
    {
        private Graph Graph { get; set; }
        private int? Index { get; set; }
        public ConcreteGraphIterator(Graph graph)
        {
            Graph = graph;
            Index = graph.Vertexes.Any() ? 0 : null;
        }

        public ISubject GetCurrent()
        {
            if (Index is not null)
            {
                return Graph.Vertexes[Index.GetValueOrDefault()];
            }
            else
            {
                return null;
            }
            
        }

        public bool IsDone()
        {
            return (Index >= Graph.Vertexes.Count);
        }

        public void Next()
        {
            Index++;
        }
    }
}
