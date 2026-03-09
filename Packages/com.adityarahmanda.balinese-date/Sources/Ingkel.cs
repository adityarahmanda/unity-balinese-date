namespace BalineseCalendar
{
    public sealed class Ingkel
    {
        public int Id { get; }
        public string Name { get; }

        private Ingkel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static readonly Ingkel WONG = new(0, "Wong");
        public static readonly Ingkel SATO = new(1, "Sato");
        public static readonly Ingkel MINA = new(2, "Mina");
        public static readonly Ingkel MANUK = new(3, "Manuk");
        public static readonly Ingkel TARU = new(4, "Taru");
        public static readonly Ingkel BUKU = new(5, "Buku");

        public static readonly Ingkel[] Values =
        {
            WONG,
            SATO,
            MINA,
            MANUK,
            TARU,
            BUKU
        };

        public override string ToString() => Name;
        public static bool operator ==(Ingkel left, Ingkel right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            return left.Id == right.Id;
        }
        public static bool operator !=(Ingkel left, Ingkel right) => !(left == right);
        public override bool Equals(object obj) => obj is Ingkel other && this == other;
        public override int GetHashCode() => Id;
    }
}