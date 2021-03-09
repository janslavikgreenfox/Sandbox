using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    class NotRegistered : IState
    {
        private RegisterLoginState Context { get; set; }
        public void Login()
        {
            Console.WriteLine("Register first!");
        }

        public void Logout()
        {
            Console.WriteLine("Register first!");
        }

        public void Register()
        {
            Console.WriteLine("Register process here."  ); 
            Context.ChangeState(new Registered(Context));
        }
    }
}
