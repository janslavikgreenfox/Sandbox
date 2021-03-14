using System.Collections.Generic;

namespace MementoDP
{
    class CareTaker
    {
        private int Index;
        public List<IMemento> Mementos { get; set; }

        public CareTaker()
        {
            Index = -1;
            Mementos = new List<IMemento>();
        }

        public void AddMemento(IMemento m)
        {
            Mementos.Add(m);
            Index++;
        }

        public IMemento GetMemento()
        {
            if (Mementos.Count == 0)
            {
                return new NullMemento();
            }
            else
            {
                var memento = Mementos[Index];
                Mementos.RemoveAt(Index);
                Index--;
                return memento;
            }
        }
    }
}
