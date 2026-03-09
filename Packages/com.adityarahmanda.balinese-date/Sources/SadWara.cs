namespace BalineseCalendar
{
    public sealed class SadWara
    {
        public int Id { get; }
        public int Urip { get; }
        public string Name { get; }

        private SadWara(int id, int urip, string name)
        {
            Id = id;
            Urip = urip;
            Name = name;
        }

        public static readonly SadWara TUNGLEH = new(0, 7, "Tungleh");
        public static readonly SadWara ARYANG = new(1, 6, "Aryang");
        public static readonly SadWara URUKUNG = new(2, 5, "Urukung");
        public static readonly SadWara PANIRON = new(3, 8, "Paniron");
        public static readonly SadWara WAS = new(4, 9, "Was");
        public static readonly SadWara MAULU = new(5, 3, "Maulu");

        public static readonly SadWara[] Values =
        {
            TUNGLEH,
            ARYANG,
            URUKUNG,
            PANIRON,
            WAS,
            MAULU
        };

        public override string ToString() => Name;
        public static bool operator ==(SadWara left, SadWara right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            return left.Id == right.Id;
        }
        public static bool operator !=(SadWara left, SadWara right) => !(left == right);
        public override bool Equals(object obj) => obj is SadWara other && this == other;
        public override int GetHashCode() => Id;
    }
}