namespace MementoDP
{
    class Originator
    {
        public State OtherStateNotSaved { get; private set; }
        public State InternalState { get; private set; }

        public Originator(State internalState)
        {
            InternalState = internalState;
        }

        public void SetInternalState(State s)
        {
            InternalState = s;
        }

        public void RestoreFromMemento(IMemento m)
        {
            if (!m.GetType().Equals(typeof(NullMemento)))
            {
                InternalState = m.GetState();
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(this.InternalState);
        }
    }
}
