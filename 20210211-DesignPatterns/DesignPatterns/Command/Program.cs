using System;
using Command.Commands;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var graphAxis = new Axis();

            var invoker = new Invoker(
                new LinearScaleCommand(graphAxis),
                new LogScaleCommand(graphAxis),
                new SinusScaleCommand(graphAxis)
                );

            invoker.ClickedOnLinear();
            graphAxis.CurrentScale(2.0,4.0);

            invoker.ClickedOnLog();
            graphAxis.CurrentScale(2.0,4.0);
            
            invoker.ClickedOnLog();
            graphAxis.CurrentScale(2.0,4.0);

            invoker.ClickedOnLog();
            graphAxis.CurrentScale(2.0, 4.0);

            invoker.ClickedOnSinus();
            graphAxis.CurrentScale(2.0, 4.0);
        }
    }
}
