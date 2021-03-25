using System;
using System.Collections.Generic;
using System.Text;
using Builder.Products;

namespace Builder.AllBuilders
{
    class AllLinksBuilder : IBuilder
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
            var graph = new LinksGraph(transCount);
            for (int indexI = 0; indexI < transCount; indexI++)
            {
                for (int indexJ = 0; indexJ < indexI; indexJ++)
                {
                        graph.AddEdge(indexI, indexJ);
                }
            }
        }

        public void Assembly()
        {
            Result = new TransactionsWithLinks(Storage, Graph);
        }

        public TransactionsWithLinks GetResult() => Result;
    }
}
