namespace MementoDP
{
    class Memento : IMemento
    {
        private State State { get; set; }
        public Memento(State s)
        {
            State = s;
        }

        public State GetState()
        {
            return State;
        }
    }
}
