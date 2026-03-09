namespace BalineseCalendar
{
    public sealed class CaturWara
    {
        public int Id { get; }
        public int Urip { get; }
        public string Name { get; }

        private CaturWara(int id, int urip, string name)
        {
            Id = id;
            Urip = urip;
            Name = name;
        }

        public static readonly CaturWara SRI = new(0, 6, "Sri");
        public static readonly CaturWara LABA = new(1, 5, "Laba");
        public static readonly CaturWara JAYA = new(2, 1, "Jaya");
        public static readonly CaturWara MENALA = new(3, 8, "Menala");

        public static readonly CaturWara[] Values =
        {
            SRI,
            LABA,
            JAYA,
            MENALA
        };

        public override string ToString() => Name;
        public static bool operator ==(CaturWara left, CaturWara right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            return left.Id == right.Id;
        }
        public static bool operator !=(CaturWara left, CaturWara right) => !(left == right);
        public override bool Equals(object obj) => obj is CaturWara other && this == other;
        public override int GetHashCode() => Id;
    }
}