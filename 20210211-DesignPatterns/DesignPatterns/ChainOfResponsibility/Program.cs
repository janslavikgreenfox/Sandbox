using System;
using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var desHandler = new DesHandler();
            var emptyHandler = new EmptyHandler(desHandler);
            var rkeHandler = new RkeHandler(emptyHandler);
            var sstKwHandler = new SstKwHandler(rkeHandler);

            var handlerChainOfResponsibility = sstKwHandler;

            var requestSetDes = new Request(RequestType.SetDesParameter, "Set the value to 1.2");
            handlerChainOfResponsibility.HandleRequest(requestSetDes);

            var overallRequest = new Request(RequestType.SetAll, "Settings for all turbulent models");
            handlerChainOfResponsibility.HandleRequest(overallRequest);

            var requestSetA1ForSstKw = new Request(RequestType.SetA1, "Set A1 to the value 0.6");
            handlerChainOfResponsibility.HandleRequest(requestSetA1ForSstKw);

        }
    }
}
