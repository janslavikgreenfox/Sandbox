using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.TemplateClasses
{
    class LinearEvaluation : AbstractEvaluation
    {
        protected override double transformation (double argument)
        {
            return argument;
        }
    }
}
