namespace MementoDP
{
    class State
    {
        public int Id { get; set; }
        public string Info { get; set; }
        public byte Flags { get; set; }
        public State(int id=0, string info="", byte flags=0x00)
        {
            Id = id;
            Info = info;
            Flags = flags;
        }
    }
}
