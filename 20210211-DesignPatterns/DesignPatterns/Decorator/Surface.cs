using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Surface : WorkflowStone
    {
        public override int Postpro()
        {
            Console.WriteLine("This is Surface postpro.... done.");
            return 10;
        }
    }
}
