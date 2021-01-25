using System;

namespace StringListDictArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var str1 = "The lazy dog jumps over the brown fox.";
            var indices = Indices(str1);

            //Update
            var firstInsertIndex = 3;
            var inserted = Inserting(firstInsertIndex,str1);
            var insertedToEnd = Inserting(str1.Length,str1);

            var replacedE = str1.Replace('e', '.');
            var replaceSubstring = str1.Replace("fox", "swan").Replace("dog","");
            var replace2 = str1.Replace("fox", "swan");

            // Split
            var str2 = "0123456789.;a.;.45.;>.;;.";
            var splitted1 = str2.Split(';');
            var splitted2 = str2.Split(new char[] { '.',';'});
            var splitted3 = str2.Split(new char[] { '.',';'},StringSplitOptions.RemoveEmptyEntries);
            var splitted4 = str2.Split(".;");
            var splitted5 = str2.Split(';', 3);
           

            // Delete, patch
            var removedToEnd = str1.Remove(firstInsertIndex);
            var removed = str1.Remove(firstInsertIndex,1);
            // var removedFromVeryEnd = str1.Remove(str1.Length); ArgumentOutOfRangeException
            var removedLastChar = str1.Remove(str1.Length-1);

            // Pad & trim
            var padLeft1 = str1.PadLeft(42,'.');
            var padRight1 = str1.PadRight(42,'-');

            var trimLeft = str1.PadLeft(50,'+').TrimStart(new char[] {'.' });
            var trimRight  = str1.PadRight(50,'.').TrimEnd('.');
            
            var trim = $"./  ... {str1} .---=//\\";
            trim = trim.Trim(new char[] {'.','-','\\','/'});

            var toLower = ".; \\/".ToLower();
            var toLover1 = str1.ToLower();
            var toUpper = ".; \\/".ToUpper();
            var toUpper1 = str1.ToUpper();
            ;
        }

        
        public static string Inserting(int startIndex,string input)
        {
            var output = input.Insert(startIndex, ";googling");
            return output;
        }

        public static int[] Indices(string input)
        {
            var output = new int[7];
            output[0] = input.IndexOf('e');
            output[1] = input.LastIndexOf('e');
            output[2] = input.IndexOfAny("aeoiuy".ToCharArray());
            output[3] = input.LastIndexOfAny("aeoiuy".ToCharArray());
            output[4] = input.IndexOfAny($".;:[]{{}}()/\\_-=+".ToCharArray());
            output[5] = input.LastIndexOfAny($".;:[]{{}}()/\\_-=+".ToCharArray());
            output[6] = input.LastIndexOfAny($"^".ToCharArray());
            return output;
        }
    }
}
