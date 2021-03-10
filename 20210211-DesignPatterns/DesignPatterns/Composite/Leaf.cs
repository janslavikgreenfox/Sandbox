using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Leaf : IComponent
    {
        private string TestName { set; get; }
        public Leaf(string testName)
        {
            TestName = testName;
        }

        public void Run()
        {
            Console.WriteLine($"This is the test: {TestName}");
        }
    }
}
