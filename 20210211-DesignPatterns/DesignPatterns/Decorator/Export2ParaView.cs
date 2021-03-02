using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Export2ParaView : AddOnDecorator
    {
        public Export2ParaView(WorkflowStone ws) : base(ws)
        {}
        public override int Postpro()
        {
            Console.WriteLine("Exporting to the ParaView...");
            return this.ws.Postpro();
        }
    }
}
