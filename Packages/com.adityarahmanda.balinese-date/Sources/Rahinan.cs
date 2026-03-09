namespace BalineseCalendar
{
    public sealed class Rahinan
    {
        public int Id { get; }
        public string Name { get; }

        private Rahinan(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static readonly Rahinan SOMA_RIBEK = new(0, "Soma Ribek");
        public static readonly Rahinan SABUH_EMAS = new(1, "Sabuh Emas");
        public static readonly Rahinan PAGER_WESI = new(2, "Pager Wesi");
        public static readonly Rahinan TUMPEK_LANDEP = new(3, "Tumpek Landep");
        public static readonly Rahinan TUMPEK_UDUH = new(4, "Tumpek Uduh");
        public static readonly Rahinan SUGIHAN_JAWA = new(5, "Sugihan Jawa");
        public static readonly Rahinan SUGIHAN_BALI = new(6, "Sugihan Bali");
        public static readonly Rahinan PENYEKEBAN_GALUNGAN = new(7, "Penyekeban Galungan");
        public static readonly Rahinan PENYAJAN_GALUNGAN = new(8, "Penyajan Galungan");
        public static readonly Rahinan PENAMPAHAN_GALUNGAN = new(9, "Penampahan Galungan");
        public static readonly Rahinan GALUNGAN = new(10, "Galungan");
        public static readonly Rahinan MANIS_GALUNGAN = new(11, "Manis Galungan");
        public static readonly Rahinan PEMARIDAN_GURU = new(12, "Pemaridan Guru");
        public static readonly Rahinan ULIHAN = new(13, "Ulihan");
        public static readonly Rahinan PEMACEKAN_AGUNG = new(14, "Pemacekan Agung");
        public static readonly Rahinan PENAMPAHAN_KUNINGAN = new(15, "Penampahan Kuningan");
        public static readonly Rahinan KUNINGAN = new(16, "Kuningan");
        public static readonly Rahinan PEGAT_UWAKAN = new(17, "Pegat Uwakan");
        public static readonly Rahinan TUMPEK_KANDANG = new(18, "Tumpek Kandang");
        public static readonly Rahinan TUMPEK_WAYANG = new(19, "Tumpek Wayang");
        public static readonly Rahinan SARASWATI = new(20, "Saraswati");
        public static readonly Rahinan BANYU_PINARUH = new(21, "Banyu Pinaruh");
        public static readonly Rahinan SIWA_RATRI = new(22, "Siwa Ratri");
        public static readonly Rahinan TAWUR_AGUNG_KASANGA = new(23, "Tawur Agung Kasanga");
        public static readonly Rahinan NYEPI = new(24, "Nyepi");
        public static readonly Rahinan NGEMBAK_GENI = new(25, "Ngembak Geni");
        public static readonly Rahinan BUDA_CEMENG = new(26, "Buda Cemeng");
        public static readonly Rahinan ANGGARA_KASIH = new(27, "Anggara Kasih");
        public static readonly Rahinan KAJENG_KLIWON = new(28, "Kajeng Kliwon");
        public static readonly Rahinan PURNAMA = new(29, "Purnama");
        public static readonly Rahinan TILEM = new(30, "Tilem");

        public static readonly Rahinan[] Values =
        {
            SOMA_RIBEK,
            SABUH_EMAS,
            PAGER_WESI,
            TUMPEK_LANDEP,
            TUMPEK_UDUH,
            SUGIHAN_JAWA,
            SUGIHAN_BALI,
            PENYEKEBAN_GALUNGAN,
            PENYAJAN_GALUNGAN,
            PENAMPAHAN_GALUNGAN,
            GALUNGAN,
            MANIS_GALUNGAN,
            PEMARIDAN_GURU,
            ULIHAN,
            PEMACEKAN_AGUNG,
            PENAMPAHAN_KUNINGAN,
            KUNINGAN,
            PEGAT_UWAKAN,
            TUMPEK_KANDANG,
            TUMPEK_WAYANG,
            SARASWATI,
            BANYU_PINARUH,
            SIWA_RATRI,
            TAWUR_AGUNG_KASANGA,
            NYEPI,
            NGEMBAK_GENI,
            BUDA_CEMENG,
            ANGGARA_KASIH,
            KAJENG_KLIWON,
            PURNAMA,
            TILEM
        };

        public override string ToString() => Name;
        public static bool operator ==(Rahinan left, Rahinan right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            return left.Id == right.Id;
        }
        public static bool operator !=(Rahinan left, Rahinan right) => !(left == right);
        public override bool Equals(object obj) => obj is Rahinan other && this == other;
        public override int GetHashCode() => Id;
    }
}