using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    class NotLogged : IState
    {
        private RegisterLoginState Context { get; set; }
        public NotLogged(RegisterLoginState context)
        {
            Context = context;
        }

        public void Login()
        {
            Console.WriteLine("The logging process here...");
            var isLoggingSuccessfull = (Console.ReadLine()==string.Empty) ? false : true;
            if (isLoggingSuccessfull)
            {
                Context.ChangeState(new Logged(Context));
            }
        }

        public void Logout()
        {
            Console.WriteLine("Not logged.");
        }

        public void Register()
        {
            Console.WriteLine("Register process here");
            Context.ChangeState(new Registered(Context));
        }
    }
}
