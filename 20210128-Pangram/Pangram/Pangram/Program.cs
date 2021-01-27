using System;
using System.Linq;

namespace Pangram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
