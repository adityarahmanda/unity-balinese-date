namespace BalineseCalendar
{
    public struct Wuku
    {
        public int Id { get; }
        public int Urip { get; }
        public string Name { get; }

        private Wuku(int id, int urip, string name)
        {
            Id = id;
            Urip = urip;
            Name = name;
        }

        public static readonly Wuku SINTA = new(0, 7, "Sinta");
        public static readonly Wuku LANDEP = new(1, 1, "Landep");
        public static readonly Wuku UKIR = new(2, 4, "Ukir");
        public static readonly Wuku KULANTIR = new(3, 6, "Kulantir");
        public static readonly Wuku TOLU = new(4, 5, "Tolu");
        public static readonly Wuku GUMBREG = new(5, 8, "Gumbreg");
        public static readonly Wuku WARIGA = new(6, 9, "Wariga");
        public static readonly Wuku WARIGADEAN = new(7, 3, "Warigadean");
        public static readonly Wuku JULUNGWANGI = new(8, 7, "Julungwangi");
        public static readonly Wuku SUNGSANG = new(9, 1, "Sungsang");
        public static readonly Wuku DUNGULAN = new(10, 4, "Dungulan");
        public static readonly Wuku KUNINGAN = new(11, 6, "Kuningan");
        public static readonly Wuku LANGKIR = new(12, 5, "Langkir");
        public static readonly Wuku MEDANGSIA = new(13, 8, "Medangsia");
        public static readonly Wuku PUJUT = new(14, 9, "Pujut");
        public static readonly Wuku PAHANG = new(15, 3, "Pahang");
        public static readonly Wuku KRULUT = new(16, 7, "Krulut");
        public static readonly Wuku MERAKIH = new(17, 1, "Merakih");
        public static readonly Wuku TAMBIR = new(18, 4, "Tambir");
        public static readonly Wuku MEDANGKUNGAN = new(19, 6, "Medangkungan");
        public static readonly Wuku MATAL = new(20, 5, "Matal");
        public static readonly Wuku UYE = new(21, 8, "Uye");
        public static readonly Wuku MENAIL = new(22, 9, "Menail");
        public static readonly Wuku PRANGBAKAT = new(23, 3, "Prangbakat");
        public static readonly Wuku BALA = new(24, 7, "Bala");
        public static readonly Wuku UGU = new(25, 1, "Ugu");
        public static readonly Wuku WAYANG = new(26, 4, "Wayang");
        public static readonly Wuku KLAWU = new(27, 6, "Klawu");
        public static readonly Wuku DUKUT = new(28, 5, "Dukut");
        public static readonly Wuku WATUGUNUNG = new(29, 8, "Watugunung");

        public static readonly Wuku[] Values = 
        {
            SINTA, LANDEP, UKIR, KULANTIR, TOLU, GUMBREG, WARIGA, WARIGADEAN,
            JULUNGWANGI, SUNGSANG, DUNGULAN, KUNINGAN, LANGKIR, MEDANGSIA,
            PUJUT, PAHANG, KRULUT, MERAKIH, TAMBIR, MEDANGKUNGAN, MATAL, UYE,
            MENAIL, PRANGBAKAT, BALA, UGU, WAYANG, KLAWU, DUKUT, WATUGUNUNG
        };

        public override string ToString() => Name;

        public static bool operator ==(Wuku left, Wuku right) => left.Id == right.Id;
        public static bool operator !=(Wuku left, Wuku right) => left.Id != right.Id;

        public override bool Equals(object obj) => obj is Wuku other && this == other;
        public override int GetHashCode() => Id;
    }
}