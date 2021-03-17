using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Expressions
{
    abstract class OperatorExpression : IExpression
    {
        private IExpression Left { get; set; }
        private IExpression Right { get; set; }
        protected OperatorExpression(IExpression left, IExpression right)
        {
            Left = left;
            Right = right;
        }

        protected abstract string DoOperation(string left, string right);
        public void Interpret(Context context)
        {
            Left.Interpret(context);
            var leftValue = context.Result.Pop();
            Right.Interpret(context);
            var rightValue = context.Result.Pop();

            var operationResult = DoOperation(leftValue, rightValue); 

            context.Result.Push(operationResult);
        }
    }
}
