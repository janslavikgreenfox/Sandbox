using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Volume : WorkflowStone
    {
        public override int Postpro()
        {
            Console.WriteLine("This is Volume postpro.... done.");
            return 100;
        }
    }
}
