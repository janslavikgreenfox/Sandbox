using System;
using System.Collections.Generic;
using System.Text;
using Builder.AllBuilders;
using Builder.Products;

namespace Builder.Directors
{
    class Director
    {
        private IBuilder Builder { set; get; }
        public Director(IBuilder builder)
        {
            Builder = builder;
        }

        public void Construct(List<string> allTransaction)
        {
            Builder.CreateStorage(allTransaction);
            Builder.CreateLinks();
            Builder.Assembly();
        }
    }
}
