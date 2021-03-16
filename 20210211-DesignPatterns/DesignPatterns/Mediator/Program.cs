using System;
using Mediator.Colleagues;
using Mediator.Mediators;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var med = new ConcreteMediator();

            var a = new ApplicationA("Alice", med);
            var b = new ApplicationA("Bob", med);
            var c = new ApplicationA("Charlie", med);

            a.Send("Request to everyone, I need help");

            b.Send("I am here, my coord is 12AF41.");

            c.Send("I am listening, but not able to help.");

            a.Send("Hey b, my coord is 12AG78, I am sinking, help!");

            b.Send("Okay, find your position, rushing to help you");
        }
    }
}
