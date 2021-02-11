using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.TemplateClasses
{
    class QuadraticEvaluation : AbstractEvaluation
    {
        protected override double transformation (double argument)
        {
            return Math.Pow(argument,2) ;
        }
    }
}
