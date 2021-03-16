using System;
using System.Collections.Generic;
using System.Text;
using Mediator.Mediators;

namespace Mediator.Colleagues
{
    class ApplicationB : Colleague
    {
        public ApplicationB(string name, IMediator med) : base(name, med) { }
    }
}
