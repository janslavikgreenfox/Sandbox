using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace StackQueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var queue = new Queue<int>();
            queue.Dequeue();

            var stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(50);

            var currentPeak = stack.Peek();

            //var stack = new Con

        
        }
    }
}
