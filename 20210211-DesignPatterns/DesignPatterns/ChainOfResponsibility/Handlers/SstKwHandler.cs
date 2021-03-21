using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Handlers
{
    class SstKwHandler : BaseHandler
    {
        public SstKwHandler() : base() { }
        public SstKwHandler(BaseHandler successor) : base(successor) { }

        public override void HandleRequest(Request request)
        {
            Console.WriteLine("SST k-w handler");
            if (request.GetKind() == RequestType.SetAll)
            {
                Console.WriteLine("Overall setting");
            }
            if (request.GetKind() == RequestType.SetA1)
            {
                Console.WriteLine("Setting the A1");
            }
            base.HandleRequest(request);
        }
    }
}
