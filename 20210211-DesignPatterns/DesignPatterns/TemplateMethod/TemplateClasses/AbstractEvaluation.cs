using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod.TemplateClasses
{
    public abstract class AbstractEvaluation
    {
        public double CostFunctionEvaluate(double[] input) 
            // template method
        {
            return input.Select(x => transformation(x)).Sum();
        }

        protected abstract double transformation(double argument);
            // primitive operation
            // abstract - never called - empty body
      
    }
}
