using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class Number : IExpression
    {
        public string Num { set; get; }
        public Number(int num)
        {
            Num = num.ToString();
        }

        public void Interpret(Context context)
        {
            context.Result.Push(Num);
        }
    }
}
