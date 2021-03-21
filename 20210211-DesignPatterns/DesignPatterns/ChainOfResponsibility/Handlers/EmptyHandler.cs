using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Handlers
{
    class EmptyHandler : BaseHandler
    {
        public EmptyHandler() : base() { }
        public EmptyHandler(BaseHandler successor) : base(successor) { }
    }
}
