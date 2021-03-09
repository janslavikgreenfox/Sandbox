using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var loginWebPageService = new RegisterLoginState();

            // User is trying to login
            loginWebPageService.Login();

            // It did not work, so he/she is trying to register
            loginWebPageService.Register();

            // Successfully registered, so he/she is trying to login
            loginWebPageService.Login();

            // Success, so after while to logout
            loginWebPageService.Logout();
            
            // Oh no, it was by mistake, login again
            loginWebPageService.Login();

            // And by mistake pressing the register button
            loginWebPageService.Register();
        }
    }
}
