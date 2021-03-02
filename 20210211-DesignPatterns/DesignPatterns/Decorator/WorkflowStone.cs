using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class WorkflowStone
    {
        public int Id { get; set; }

        virtual public int Postpro()
        {
            Console.WriteLine("This is Postpro");
            return 0;
        }
    }
}
