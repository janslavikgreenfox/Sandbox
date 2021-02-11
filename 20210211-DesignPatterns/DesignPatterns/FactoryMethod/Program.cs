using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var factory = new ConcreteCreator();

            var fcn1 = factory.Create(FitFunctionType.Polynomial);
            Console.WriteLine($"fcn1 type of fit is: {fcn1.GetTypeOfFit()}");

            var fcn2 = factory.Create(FitFunctionType.Table);
            Console.WriteLine($"fcn2 type of fit is: {fcn2.GetTypeOfFit()}");
            
            var fcn3 = factory.Create(FitFunctionType.Table);
            Console.WriteLine($"fcn3 type of fit is: {fcn3.GetTypeOfFit()}");

        }

        public enum FitFunctionType
        {
            Polynomial,
            Table,
            Spline
        } 
    }
}
