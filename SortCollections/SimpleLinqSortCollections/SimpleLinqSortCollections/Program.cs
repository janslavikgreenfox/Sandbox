using System;

namespace SimpleLinqSortCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] test1 = new string[] { "H", "A", "L", "O", "E" };
            foreach(var item in SortedByArraySort(test1))
            {
                Console.WriteLine(item);
            }

            foreach (var item in GenericSort<string>(test1))
            {
                Console.WriteLine(item);
            }
        }

        static int[] SortedByArraySort(int[] inputToSort)
        {
            int [] sortedOutput = inputToSort;
            Array.Sort(sortedOutput);
            return sortedOutput;
        }

        static string[] SortedByArraySort(string[] inputToSort)
        {
            string[] sortedOutput = inputToSort;
            Array.Sort(sortedOutput);
            return sortedOutput;
        }

       static  T[] GenericSort<T>(T[] inputToSort) where T : IComparable
        {
            T[] sortedOutput = inputToSort;
            Array.Sort(sortedOutput);
            return sortedOutput;
        }
    }
}
