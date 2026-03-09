namespace BalineseCalendar
{
    public sealed class PancaWara
    {
        public int Id { get; }
        public int Urip { get; }
        public int Kupih { get; }
        public string Name { get; }

        private PancaWara(int id, int urip, int kupih, string name)
        {
            Id = id;
            Urip = urip;
            Kupih = kupih;
            Name = name;
        }

        public static readonly PancaWara PAING = new(0, 9, 3, "Paing");
        public static readonly PancaWara PON = new(1, 7, 4, "Pon");
        public static readonly PancaWara WAGE = new(2, 4, 5, "Wage");
        public static readonly PancaWara KLIWON = new(3, 8, 1, "Kliwon");
        public static readonly PancaWara UMANIS = new(4, 5, 2, "Umanis");
        
        public static readonly PancaWara[] Values =
        {
            PAING,
            PON,
            WAGE,
            KLIWON,
            UMANIS
        };
        
        public override string ToString() => Name;
        public static bool operator ==(PancaWara left, PancaWara right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            return left.Id == right.Id;
        }
        public static bool operator !=(PancaWara left, PancaWara right) => !(left == right);
        public override bool Equals(object obj) => obj is PancaWara other && this == other;
        public override int GetHashCode() => Id;
    }
}