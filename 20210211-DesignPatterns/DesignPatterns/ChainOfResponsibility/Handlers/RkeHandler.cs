using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Handlers
{
    class RkeHandler : BaseHandler
    {
        public RkeHandler() : base() { }
        public RkeHandler(BaseHandler successor) : base(successor) { }

        public override void HandleRequest(Request request)
        {
            Console.WriteLine("Rke Handler");
            if (request.GetKind() == RequestType.SetAll)
            {
                Console.WriteLine("Overall setting");
            }
            base.HandleRequest(request);
        }
    }
}
