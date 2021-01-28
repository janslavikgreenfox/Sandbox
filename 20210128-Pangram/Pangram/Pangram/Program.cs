using System;
using System.Collections.Generic;
using System.Linq;

namespace Pangram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var temp1 = new int[0][] {  };
            var getLength1 = temp1.GetLength(0);
            //var getLength2 = temp1.GetLength(1);
            var length = temp1.Length;

            var temp2 = new int[] { 1, 4, 6, -2, 12 };
            //Array.Sort(temp2);
            var temp3 = temp2.ToList();
            temp3.Sort();
        }

        public static bool Pangram(string input)
        {
            var lowerCase = input.ToLower();

            var letters = "abcdefghijklmnopqrstuvxyz";

            foreach (var letter in letters)
            {
                if (!lowerCase.Contains(letter))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool PangramAlternative2(string input2)
        {
            var letters = "abcdefghijklmnopqrstuvwxyz";
            var intersection = letters.Intersect(input2.ToLower());
            return intersection.SequenceEqual(letters);
        }

        public static bool PangramAlternative3(string input) =>
        "abcdefghijklmnopqrstuvwxyz".All(x => input.ToLower().Contains(x));
    }
}
