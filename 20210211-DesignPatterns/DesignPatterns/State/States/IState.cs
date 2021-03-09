using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    interface IState
    {
        void Register();
        void Login();
        void Logout();
    }
}
