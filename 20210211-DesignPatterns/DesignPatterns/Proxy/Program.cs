using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var proxy = new Proxy("SomePathname");

            Console.WriteLine("\nCells count 1st time");
            var ask1stTime = proxy.GetCellsCount();

            Console.WriteLine("\nCells count 2nd time");
            var ask2ndTime = proxy.GetCellsCount();
        }
    }
}
