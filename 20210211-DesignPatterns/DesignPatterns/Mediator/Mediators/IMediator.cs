using System;
using System.Collections.Generic;
using System.Text;
using Mediator.Colleagues;

namespace Mediator.Mediators
{
    abstract class IMediator
    {
        private List<Colleague> colleagues;
        List<Colleague> Colls
        {
            get => colleagues;
            set => colleagues = value;
        }

        public IMediator()
        {
            colleagues = new List<Colleague>();
        }
        public void AddColleague(Colleague c)
        {
            colleagues.Add(c);
        }
        public void InformAll(string message)
        {
            foreach (var c in colleagues)
            {
                c.Receive(message);
            }
        }
    }
}
