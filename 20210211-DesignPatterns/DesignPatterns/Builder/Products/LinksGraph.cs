using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Products
{
    class LinksGraph
    {
        public List<int> Vertexes { get; private set; }
        public List<Tuple<int,int>> Edges { get; private set; }
        public LinksGraph(int VertexCount)
        {
            Vertexes = new List<int>(Enumerable.Range(0,VertexCount));
            Edges = new List<Tuple<int,int>>();
        }
        public void AddEdge(int from, int to)
        {
            var edge = new Tuple<int, int> ( from, to );
            Edges.Add(edge);
        }




    }
}
