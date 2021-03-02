using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class AddOnDecorator : WorkflowStone
    {
        public WorkflowStone ws { get; private set; }
        protected AddOnDecorator(WorkflowStone ws)
        {
            this.ws = ws;
        }
    }
}
