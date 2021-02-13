using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var singleton = Singleton.GetInstance("Das Ganze Tschechiche volk ist ein Simulantenbande.");
            var info = singleton.Access();

            //Singleton secondInstance = new Singleton("Jesco raz."); // not possible

            var singletonSecond = Singleton.GetInstance("Another sentence");
            var infoSecond = singletonSecond.Access();

            var AreSame = (singleton == singletonSecond);
        }
    }
}
