namespace MementoDP
{
    class NullMemento : IMemento
    {
        public State GetState()
        {
            return new State();
        }
    }
}
