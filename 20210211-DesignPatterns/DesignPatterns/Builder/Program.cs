using System;
using System.Collections.Generic;
using Builder.AllBuilders;
using Builder.Directors;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var builder = new CircularLinksBuilder();
            var director = new Director(builder);

            director.Construct(new List<string>() { "45d4","5589","a413","ab90"});

            var concreteProduct = builder.GetResult();
            
        }
    }
}
