using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var factory = new ConcreteFactoryStandard();
            var function = new FunctionDefinedByTable(factory);


            var result = function.GetValue(1.23);
        }
    }
}
