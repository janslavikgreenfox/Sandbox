using System;
using System.Collections.Generic;
using Iterator.Iterable;
using Iterator.Subject;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var a = new OneVertex(new int[] { 0, 1, 4, 6, 7 });
            var b = new OneVertex(new int[] { 0, 2, 4, 8, 7 });
            var c = new OneVertex(new int[] { 0, 2, 4, -5 });
            var d = new OneVertex(new int[] { 0, 1, 0, 0, 1 });

            var edge1 = new Tuple<ISubject, ISubject>(a, b);

            var graph = new Graph(
                new List<ISubject> {a, b, c, d },
                new List<Tuple<ISubject, ISubject>> { 
                          new Tuple<ISubject,ISubject>(a,b), 
                          new Tuple<ISubject,ISubject>(b,c), 
                          new Tuple<ISubject,ISubject>(c,d), 
                          new Tuple<ISubject,ISubject>(a,d) 
                         }
                );

            var iterator = graph.GetIterator();

            const char Delimiter = ',';
            while (!iterator.IsDone())
            {
                Console.WriteLine(new String('-',25));
                
                var subject = iterator.GetCurrent();
                string subjectToString = String.Empty;
                foreach(var number in subject.GetRepresentation())
                {
                    subjectToString += number.ToString();
                    subjectToString += Delimiter;
                }
                subjectToString = subjectToString.TrimEnd(Delimiter);
                Console.WriteLine(subjectToString);

                iterator.Next();
            }
        }
    }
}
