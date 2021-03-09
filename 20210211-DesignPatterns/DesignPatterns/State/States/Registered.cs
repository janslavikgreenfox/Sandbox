using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    class Registered : IState
    {
        private RegisterLoginState Context { get; set; }
        public Registered(RegisterLoginState context)
        {
            Context = context;
        }

        public void Login()
        {
            Console.WriteLine("Logging process here.");
            Context.ChangeState(new Logged(Context));
        }

        public void Logout()
        {
            Console.WriteLine("Not logged.");
        }

        void IState.Register()
        {
            Console.WriteLine("Already registered!"); 
        }
    }
}
