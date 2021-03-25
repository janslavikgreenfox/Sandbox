using System;
using System.Collections.Generic;
using System.Text;
using Builder.Products;

namespace Builder.AllBuilders
{
    class CircularLinksBuilder : IBuilder
    {
        private Storage Storage { get; set; }
        private LinksGraph Graph { get; set; }
        private TransactionsWithLinks Result { get; set; }
     
        public void CreateStorage(List<string> allTransactions)
        {
            // create product A
            Storage = new Storage(allTransactions);
        }

        public void CreateLinks()
        {
            //create product B
            var transCount = Storage.StorageRepresentation.Count;
            Graph = new LinksGraph(transCount);
            for (int index = 0; index + 1 < transCount; index++)
            {
                Graph.AddEdge(index, index + 1);
            }
            Graph.AddEdge(transCount, 0); ;
        }

        public void Assembly()
        {
            Result = new TransactionsWithLinks(Storage, Graph);
        }

        public TransactionsWithLinks GetResult() => Result;

    }
}
