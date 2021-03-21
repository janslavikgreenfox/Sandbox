using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Handlers
{
    class DesHandler : BaseHandler
    {
        public DesHandler() : base() { }
        public DesHandler(BaseHandler successor) : base(successor)
        { }

        public override void HandleRequest(Request request)
        {
            Console.WriteLine("DES Handler");
            if (request.GetKind() == RequestType.SetDesParameter)
            {
                Console.WriteLine("Setting the des parameter");
            }
            if (request.GetKind() == RequestType.SetAll)
            {
                Console.WriteLine("Overall setting");
            }
            base.HandleRequest(request);
        }
    }
}
