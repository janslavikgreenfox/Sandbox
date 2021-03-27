using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Visitables;

namespace Visitor.Visitors
{
    interface IVisitor
    {
        double Visit(Baloon baloon);
        double Visit(Drone drone);
        double Visit(Airplane airplane);
    }
}
