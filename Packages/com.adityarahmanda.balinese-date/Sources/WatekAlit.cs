namespace BalineseCalendar
{
    public sealed class WatekAlit
    {
        public int Id { get; }
        public string Name { get; }

        private WatekAlit(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static readonly WatekAlit LINTAH = new(0, "Lintah");
        public static readonly WatekAlit ULER = new(1, "Uler");
        public static readonly WatekAlit GAJAH = new(2, "Gajah");
        public static readonly WatekAlit LEMBU = new(3, "Lembu");

        public static readonly WatekAlit[] Values =
        {
            LINTAH,
            ULER,
            GAJAH,
            LEMBU
        };

        public override string ToString() => Name;
        public static bool operator ==(WatekAlit left, WatekAlit right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            return left.Id == right.Id;
        }
        public static bool operator !=(WatekAlit left, WatekAlit right) => !(left == right);
        public override bool Equals(object obj) => obj is WatekAlit other && this == other;
        public override int GetHashCode() => Id;
    }
}