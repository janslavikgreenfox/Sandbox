using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var target = new Adapter(new Adaptee());

            var log2of128 = target.request(128, 2);
        }
    }
}
