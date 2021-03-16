using System;
using System.Collections.Generic;
using System.Text;
using Mediator.Mediators;

namespace Mediator.Colleagues
{
    class ApplicationA : Colleague
    {
        public ApplicationA(string name, IMediator med): base(name,med) { }
    }
}
