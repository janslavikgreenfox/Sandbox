using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var testA = new int[] { -0, 1, 2, 3, 6, 18, 108, -250 };

            var result = PrepApp(testA);
            PredicateTests(testA);

            var testB = new List<int>{ 0,1,4,5,6,7,8};
            SetOperations(testA, testB);
            ;
        }

        private static int[] PrepApp(int[] input)
        {
            return input.Prepend(-1).Append(-1).ToArray();
        }

        public static void PredicateTests(int[] input)
        {
            var a1 = input.All(x => x > 0);
            var a2 = input.Any(x => x > 107);
        }

        public static void SetOperations (IEnumerable<int> A,IEnumerable<int> B)
        {
            var union = A.Union(B);
            var intersection = A.Intersect(B);
            var difference = A.Except(B);

            var nonDistinct = new int[] { -1, -1, 0, 1, 2, 2, -1};
            var distinct = nonDistinct.Distinct().ToList();

            // pa no, mi du la jan
        }




    }
}
