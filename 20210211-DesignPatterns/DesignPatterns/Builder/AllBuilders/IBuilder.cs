using System;
using System.Collections.Generic;
using System.Text;
using Builder.Products;

namespace Builder.AllBuilders
{
    interface IBuilder
    {
        void CreateStorage(List<string> allTransactions);
        void CreateLinks();
        void Assembly();
        TransactionsWithLinks GetResult();
    }
}
