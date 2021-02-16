using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Commands
{
    class LinearScaleCommand : AbstractCommand
    {
        public LinearScaleCommand(Axis axis) : base(axis)
        {        }

        public override void Execute()
        {
            Axis.ScaleToLinear();
        }

        public override void Unexecute()
        {
            Axis.ScaleToLinear();
        }
    }
}
