using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    class Logged : IState
    {
        private RegisterLoginState Context { get; set; }
        public Logged(RegisterLoginState context)
        {
            Context = context;
        }

        public void Login()
        {
            Console.WriteLine("Already logged in");
        }

        public void Logout()
        {
            Context.ChangeState(new NotLogged(Context));
        }

        public void Register()
        {
            Console.WriteLine("Registering process here..."); 
            Context.ChangeState(new Registered(Context));
        }
    }
}
