namespace BalineseCalendar
{
    public struct WatekMadya
    {
        public int Id { get; }
        public string Name { get; }

        private WatekMadya(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static readonly WatekMadya WONG = new(0, "Wong");
        public static readonly WatekMadya GAJAH = new(1, "Gajah");
        public static readonly WatekMadya WATU = new(2, "Watu");
        public static readonly WatekMadya BUTA = new(3, "Buta");
        public static readonly WatekMadya SUKU = new(4, "Suku");

        public static readonly WatekMadya[] Values =
        {
            WONG,
            GAJAH,
            WATU,
            BUTA,
            SUKU
        };

        public override string ToString() => Name;

        public static bool operator ==(WatekMadya left, WatekMadya right) => left.Id == right.Id;
        public static bool operator !=(WatekMadya left, WatekMadya right) => left.Id != right.Id;

        public override bool Equals(object obj) => obj is WatekMadya other && this == other;
        public override int GetHashCode() => Id;
    }
}