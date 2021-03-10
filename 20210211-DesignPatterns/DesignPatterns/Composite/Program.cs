using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var unitTest1 = new Leaf("Unit Test 1");
            var unitTest2 = new Leaf("Unit Test 2");
            var unitTest3 = new Leaf("Unit Test 3");

            var unitTestGroup = new Composite(
                "Unit Tests Group",
                new List<IComponent>() { unitTest1, unitTest2, unitTest3 }
                );

            var humanInt1 = new Leaf("Human interface test 1");
            var humanInt2 = new Leaf("Human interface test 2");

            var humanMachineUXGroup = new Composite(
                "Human-Machine Interface Tests Group",
                new List<IComponent>() { humanInt1, humanInt2 }
                );

            var globalTest = new Leaf("Global Test");

            var root = new Composite(
                "Global Test Group",
                new List<IComponent>() { globalTest, unitTestGroup, humanMachineUXGroup }
                );

            root.Run();
        }
    }
}
