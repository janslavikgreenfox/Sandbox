using System;
using System.Collections.Generic;
using System.Text;
using State.States;

namespace State
{
    class RegisterLoginState
    {
        public  IState InternalState { get; private set; }

        public RegisterLoginState()
        {
            this.InternalState = new NotLogged(this);
        }
        public void ChangeState(IState newState)
        {
            this.InternalState = newState;
        }

        public void Login()
        {
            InternalState.Login();
        }

        public void Logout()
        {
            InternalState.Logout();
        }
        public void Register()
        {
            InternalState.Register();
        }
    }
}
