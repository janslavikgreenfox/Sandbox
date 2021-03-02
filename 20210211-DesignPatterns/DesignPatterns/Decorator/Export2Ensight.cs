using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Export2Ensight : AddOnDecorator
    {
        public Export2Ensight(WorkflowStone ws) : base(ws)
        {

        }
        public override int Postpro()
        {
            Console.WriteLine("Exporting to the EnSight...");
            return 350 + this.ws.Postpro();
        }
    }
}
