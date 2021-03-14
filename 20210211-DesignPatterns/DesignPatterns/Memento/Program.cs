using System;

namespace MementoDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var careTaker = new CareTaker();
            var originator = new Originator(
                new State(1,"This is the first state", 0x01));

            originator.SetInternalState(
                new State(2, "The second case", 0x01));
            careTaker.AddMemento(originator.CreateMemento());

            originator.SetInternalState(
                new State(3, "The third state", 0x02));
            careTaker.AddMemento(originator.CreateMemento());

            originator.SetInternalState(
                new State(4, "The fourth one", 0x04));

            // Restore to 3. state
            originator.RestoreFromMemento(careTaker.GetMemento());
            // Restore to 2. state
            originator.RestoreFromMemento(careTaker.GetMemento());

            originator.SetInternalState(
                new State(5, "The fifth state", 0x08));

            // No change from current state, because no memento is saved
            originator.RestoreFromMemento(careTaker.GetMemento());
        }
    }
}
