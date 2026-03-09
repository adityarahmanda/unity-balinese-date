namespace BalineseCalendar
{
    public sealed class AstaWara
    {
        public int Id { get; }
        public int Urip { get; }
        public string Name { get; }

        private AstaWara(int id, int urip, string name)
        {
            Id = id;
            Urip = urip;
            Name = name;
        }

        public static readonly AstaWara SRI = new(0, 6, "Sri");
        public static readonly AstaWara INDRA = new(1, 5, "Indra");
        public static readonly AstaWara GURU = new(2, 8, "Guru");
        public static readonly AstaWara YAMA = new(3, 9, "Yama");
        public static readonly AstaWara LUDRA = new(4, 3, "Ludra");
        public static readonly AstaWara BRAHMA = new(5, 7, "Brahma");
        public static readonly AstaWara KALA = new(6, 1, "Kala");
        public static readonly AstaWara UMA = new(7, 4, "Uma");

        public static readonly AstaWara[] Values =
        {
            SRI,
            INDRA,
            GURU,
            YAMA,
            LUDRA,
            BRAHMA,
            KALA,
            UMA
        };

        public override string ToString() => Name;
        public static bool operator ==(AstaWara left, AstaWara right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            return left.Id == right.Id;
        }
        public static bool operator !=(AstaWara left, AstaWara right) => !(left == right);
        public override bool Equals(object obj) => obj is AstaWara other && this == other;
        public override int GetHashCode() => Id;
    }
}