using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Expressions
{
    class Divide : OperatorExpression
    {
        public Divide(IExpression left, IExpression right) : base(left, right) { }
        protected override string DoOperation(string Left, string Right)
       {
            return (Int32.Parse(Left) / Int32.Parse(Right)).ToString();
       }
    }
}
