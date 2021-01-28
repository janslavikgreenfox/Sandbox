using System;
using System.Collections.Generic;

namespace FinalExam
{
    public class Program
    {
        static void Main(string[] args)
        {
            var test1 = new int[] { 4, 2, 7, 4, 2, 3 };
            var limit1 = 15;

            var result1 = BasketFiller(test1, limit1);

            var result2 = BasketFiller(new int[0] { }, 15);

            var result3 = BasketFiller(new int[] { 10, 1, 0, 6 }, 5);

            var result4 = BasketFiller(new int[] { -1, -2, -3 }, 15);
        }

        public static int[] BasketFiller(int[] inputArray, int limit)
        {
            if (inputArray.Length == 0)
            {
                return new int[0] { };
            }

            var output = new List<int>();
            int sum = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                sum += inputArray[i];
                if (sum <= limit)
                {
                    output.Add(inputArray[i]);
                }
                else
                {
                    return output.ToArray();
                }
            }
            return output.ToArray();
        }
    }
}
