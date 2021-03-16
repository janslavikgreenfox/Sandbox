using System;
using System.Collections.Generic;
using System.Text;
using Mediator.Mediators;

namespace Mediator.Colleagues
{
    class ApplicationC : Colleague
    {
        public ApplicationC(string name, IMediator med) : base(name, med) { }
    }
}
