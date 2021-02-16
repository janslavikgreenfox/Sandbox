using System;
using System.Collections.Generic;
using System.Text;
using Command.Commands;

namespace Command
{
    class Invoker
    {
        public AbstractCommand Linear { get; set; }
        public AbstractCommand Log { get; set; }
        public AbstractCommand Sinus { get; set; }
        public Invoker(AbstractCommand linear, AbstractCommand log, AbstractCommand sinus)
        {
            Linear = linear;
            Log = log;
            Sinus = sinus;
        }
        public void ClickedOnLinear()
        {
                Linear.Execute();
        }
        public void ClickedOnLog()
        {
            if (Log.Used)
            {
                Log.Unexecute();
            }
            else
            {
                Log.Execute();
            }
            Log.Used = !Log.Used;
        }
        public void ClickedOnSinus()
        {
            if (Sinus.Used)
            {
                Sinus.Unexecute();
            }
            else
            {
                Sinus.Execute();
            }
            Sinus.Used = !Sinus.Used;
        }
    }
}
