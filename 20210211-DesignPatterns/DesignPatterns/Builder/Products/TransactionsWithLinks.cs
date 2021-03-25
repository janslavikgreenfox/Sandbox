using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Products
{
    class TransactionsWithLinks
    {
        public Storage Storage { get; set; }
        public LinksGraph Graph { get; set; }
        public TransactionsWithLinks(Storage storage, LinksGraph graph)
        {
            Storage = storage;
            Graph = graph;
        }
    }
}
