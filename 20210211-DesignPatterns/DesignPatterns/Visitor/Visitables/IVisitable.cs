using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Visitors;

namespace Visitor.Visitables
{
    interface IVisitable
    {
        double Accept(IVisitor visitor);
    }
}
