using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Commands
{
    class LogScaleCommand : AbstractCommand
    {
        public LogScaleCommand(Axis axis) : base(axis)
        { }

        public override void Execute()
        {
            Axis.ChangeScale(LogScale);
        }

        public override void Unexecute()
        {
            Axis.ScaleToLinear();
        }

        private double LogScale(double x, double module)
        {
            Console.WriteLine($"LogScale = Module {module} * Log_10( {x} )");
            return module * Math.Log10(x);
        }
    }
}
