using System;
using TemplateMethod.TemplateClasses;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var testInput = new double[] { 0, 1, 2, 3, -4 };

            var resultLinear = new LinearEvaluation().CostFunctionEvaluate(testInput);
            var resultQuadratic = new QuadraticEvaluation().CostFunctionEvaluate(testInput);
        }
    }
}
