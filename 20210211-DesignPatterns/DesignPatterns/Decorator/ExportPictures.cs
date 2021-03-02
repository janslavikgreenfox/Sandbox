using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class ExportPictures : AddOnDecorator
    {
        public ExportPictures(WorkflowStone ws): base(ws)
        {}
        public override int Postpro()
        {
            Console.WriteLine("Exporting basic pictures...");
            return this.ws.Postpro();
        }
    }
}
