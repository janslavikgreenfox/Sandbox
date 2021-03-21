using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Handlers
{
    class BaseHandler
    {
        protected BaseHandler Successor { get; set; }
        public BaseHandler()
        {
            Successor = null;
        }
        public BaseHandler(BaseHandler successor)
        {
            Successor = successor;
        }

        public virtual void HandleRequest(Request request)
        {
            if (!(Successor is null))
            {
                Successor.HandleRequest(request);
            }
        } 
    }
}
