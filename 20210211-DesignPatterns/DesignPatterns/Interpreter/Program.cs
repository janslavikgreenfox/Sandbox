using System;
using Interpreter.Expressions;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var context = new Context();

            var two = new Number(2);
            var three = new Number(3);
            var five = new Number(5);
            var eight = new Number(8);
            var eleven = new Number(11);

            // d ==  11 / 3 + 8 - 5 * 2 (infix notation)
            // d ==  11 3 / 8 + 5 - 2 * (postfix notation)
            var a = new Divide(eleven, three);
            var b = new Add(a, eight);
            var c = new Subtrack(b, five);
            var d = new Multiply(c, two);

            d.Interpret(context);

        }
    }
}
