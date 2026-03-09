namespace BalineseCalendar
{
    public sealed class SaptaWara
    {
        public int Id { get; }
        public int Urip { get; }
        public int KertaAji { get; }
        public int Kupih { get; }
        public string Name { get; }

        private SaptaWara(int id, int urip, int kertaAji, int kupih, string name)
        {
            Id = id;
            Urip = urip;
            KertaAji = kertaAji;
            Kupih = kupih;
            Name = name;
        }

        public static readonly SaptaWara REDITE = new(0, 5, 6, 3, "Redite");
        public static readonly SaptaWara SOMA = new(1, 4, 4, 4, "Soma");
        public static readonly SaptaWara ANGGARA = new(2, 3, 3, 5, "Anggara");
        public static readonly SaptaWara BUDA = new(3, 7, 6, 6, "Buda");
        public static readonly SaptaWara WRASPATI = new(4, 8, 5, 7, "Wraspati");
        public static readonly SaptaWara SUKRA = new(5, 6, 7, 1, "Sukra");
        public static readonly SaptaWara SANISCARA = new(6, 9, 8, 2, "Saniscara");

        public static readonly SaptaWara[] Values =
        {
            REDITE,
            SOMA,
            ANGGARA,
            BUDA,
            WRASPATI,
            SUKRA,
            SANISCARA
        };

        public override string ToString() => Name;
        public static bool operator ==(SaptaWara left, SaptaWara right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            return left.Id == right.Id;
        }
        public static bool operator !=(SaptaWara left, SaptaWara right) => !(left == right);
        public override bool Equals(object obj) => obj is SaptaWara other && this == other;
        public override int GetHashCode() => Id;
    }
}