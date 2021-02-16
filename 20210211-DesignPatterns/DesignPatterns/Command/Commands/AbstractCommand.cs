using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Commands
{
    public abstract class AbstractCommand
        // Command interface 
    {
        public bool Used;
        public Axis Axis { get; set; }

        public AbstractCommand(Axis axis)
        {
            this.Axis = axis;
            this.Used = false;
        }
        virtual public void Execute() { }
        virtual public void Unexecute() { }
    }
}
