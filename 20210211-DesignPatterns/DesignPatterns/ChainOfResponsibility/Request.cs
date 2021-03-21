using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    enum RequestType
    {
        SetAll = 1,
        SetA1 = 2,
        SetDesParameter = 3
    }
    class Request
    {
        private RequestType RequestKind { get; set; }
        public string Name { get; set; }
        public Request(RequestType requestKind, string name)
        {
            RequestKind = requestKind;
            Name = name;
        }

        public RequestType GetKind() => RequestKind;
  
    }
}
