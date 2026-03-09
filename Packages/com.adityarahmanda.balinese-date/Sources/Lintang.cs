namespace BalineseCalendar
{
    public sealed class Lintang
    {
        public int Id { get; }
        public string Name { get; }

        private Lintang(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static readonly Lintang GAJAH = new(0, "Gajah");
        public static readonly Lintang KIRIMAN = new(1, "Kiriman");
        public static readonly Lintang JUNG_SARAT = new(2, "Jung Sarat");
        public static readonly Lintang ATIWA_TIWA = new(3, "Atiwa Tiwa");
        public static readonly Lintang SANGKA_TIKEL = new(4, "Sangka Tikel");
        public static readonly Lintang BUBU_BOLONG = new(5, "Bubu Bolong");
        public static readonly Lintang SUNGENGE = new(6, "Sungenge");
        public static readonly Lintang ULUKU = new(7, "Uluku");
        public static readonly Lintang PEDATI = new(8, "Pedati");
        public static readonly Lintang KUDA = new(9, "Kuda");
        public static readonly Lintang GAJAH_MINA = new(10, "Gajah Mina");
        public static readonly Lintang BADE = new(11, "Bade");
        public static readonly Lintang MAGELUT = new(12, "Magelut");
        public static readonly Lintang PAGELANGAN = new(13, "Pagelangan");
        public static readonly Lintang KALA_SUNGSANG = new(14, "Kala Sungsang");
        public static readonly Lintang KUKUS = new(15, "Kukus");
        public static readonly Lintang ASU = new(16, "Asu");
        public static readonly Lintang KARTIKA = new(17, "Kartika");
        public static readonly Lintang NAGA = new(18, "Naga");
        public static readonly Lintang ANGSA_ANGREM = new(19, "Angsa Angrem");
        public static readonly Lintang PANAH = new(20, "Panah");
        public static readonly Lintang PATREM = new(21, "Patrem");
        public static readonly Lintang LEMBU = new(22, "Lembu");
        public static readonly Lintang DEPAT = new(23, "Depat");
        public static readonly Lintang TANGIS = new(24, "Tangis");
        public static readonly Lintang SALAH_UKUR = new(25, "Salah Ukur");
        public static readonly Lintang PERAHU_PEGAT = new(26, "Perahu Pegat");
        public static readonly Lintang PUWUH_ATARUNG = new(27, "Puwuh Atarung");
        public static readonly Lintang LAWEAN = new(28, "Lawean");
        public static readonly Lintang KELAPA = new(29, "Kelapa");
        public static readonly Lintang YUYU = new(30, "Yuyu");
        public static readonly Lintang LUMBUNG = new(31, "Lumbung");
        public static readonly Lintang KUMBA = new(32, "Kumba");
        public static readonly Lintang UDANG = new(33, "Udang");
        public static readonly Lintang BEGOONG = new(34, "Begoong");

        public static readonly Lintang[] Values =
        {
            GAJAH,
            KIRIMAN,
            JUNG_SARAT,
            ATIWA_TIWA,
            SANGKA_TIKEL,
            BUBU_BOLONG,
            SUNGENGE,
            ULUKU,
            PEDATI,
            KUDA,
            GAJAH_MINA,
            BADE,
            MAGELUT,
            PAGELANGAN,
            KALA_SUNGSANG,
            KUKUS,
            ASU,
            KARTIKA,
            NAGA,
            ANGSA_ANGREM,
            PANAH,
            PATREM,
            LEMBU,
            DEPAT,
            TANGIS,
            SALAH_UKUR,
            PERAHU_PEGAT,
            PUWUH_ATARUNG,
            LAWEAN,
            KELAPA,
            YUYU,
            LUMBUNG,
            KUMBA,
            UDANG,
            BEGOONG
        };
        

        public override string ToString() => Name;
        public static bool operator ==(Lintang left, Lintang right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            return left.Id == right.Id;
        }
        public static bool operator !=(Lintang left, Lintang right) => !(left == right);
        public override bool Equals(object obj) => obj is Lintang other && this == other;
        public override int GetHashCode() => Id;
    }
}