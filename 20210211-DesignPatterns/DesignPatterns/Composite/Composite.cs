using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Composite : IComponent
    {
        private string TestGroupTitle { set; get; } 
        private List<IComponent> Components { set; get; }
        public Composite(string testGroupTitle, List<IComponent> components)
        {
            this.TestGroupTitle = testGroupTitle;
            this.Components = components;
        }
        
        public void Run()
        {
            Console.WriteLine($"This is the test group: {TestGroupTitle}");
            foreach(var test in Components)
            {
                test.Run();
            }
        }
    }
}
