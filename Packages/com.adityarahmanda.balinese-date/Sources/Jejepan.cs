namespace BalineseCalendar
{
    public struct Jejepan
    {
        public int Id { get; }
        public string Name { get; }

        private Jejepan(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static readonly Jejepan MINA = new(0, "Mina");
        public static readonly Jejepan TARU = new(1, "Taru");
        public static readonly Jejepan SATO = new(2, "Sato");
        public static readonly Jejepan PATRA = new(3, "Patra");
        public static readonly Jejepan WONG = new(4, "Wong");
        public static readonly Jejepan PAKSI = new(5, "Paksi");

        public static readonly Jejepan[] Values =
        {
            MINA,
            TARU,
            SATO,
            PATRA,
            WONG,
            PAKSI
        };

        public override string ToString() => Name;

        public static bool operator ==(Jejepan left, Jejepan right) => left.Id == right.Id;
        public static bool operator !=(Jejepan left, Jejepan right) => left.Id != right.Id;

        public override bool Equals(object obj) => obj is Jejepan other && this == other;
        public override int GetHashCode() => Id;
    }
}