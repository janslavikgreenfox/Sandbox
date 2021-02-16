using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Commands
{
    class SinusScaleCommand : AbstractCommand
    {
        public SinusScaleCommand(Axis axis) : base(axis)
        { }
        public override void Execute()
        {
            Axis.ChangeScale(SinScale);
        }

        public override void Unexecute()
        {
            Axis.ScaleToLinear();
        }

        private double SinScale(double x, double module)
        {
            Console.WriteLine($"SinusScale = Module {module} * Sin( {x} )");
            return module * Math.Sin(x);
        }
    }
}
