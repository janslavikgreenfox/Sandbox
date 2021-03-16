using System;
using System.Collections.Generic;
using System.Text;
using Mediator.Mediators;

namespace Mediator.Colleagues
{
    abstract class Colleague
    {
        protected IMediator Mediator { get; set; }
        protected string Name { get; set; }
        public Colleague(string name, IMediator mediator)
        {
            Name = name;
            Mediator = mediator;
            Mediator.AddColleague(this);
        }

        public virtual void Receive(string message) 
        {
            Console.WriteLine($"Hi, I am {Name} and I have received the message: {message}");
        }
        public virtual void Send(string message) 
        {
            Console.WriteLine($"Name {Name} is sending the message : {message}");
            Mediator.InformAll(message);
        }
    }
}
