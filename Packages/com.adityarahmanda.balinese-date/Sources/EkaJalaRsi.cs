namespace BalineseCalendar
{
    public sealed class EkaJalaRsi
    {
        public int Id { get; }
        public string Name { get; }

        private EkaJalaRsi(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static readonly EkaJalaRsi BAGNA_MAPASAH = new(0, "Bagna Mapasah");
        public static readonly EkaJalaRsi BAHU_PUTRA = new(1, "Bahu Putra");
        public static readonly EkaJalaRsi BUAT_ASTAWA = new(2, "Bahu Astawa");
        public static readonly EkaJalaRsi BUAT_KINGKING = new(3, "Buat Kingking");
        public static readonly EkaJalaRsi BUAT_LARA = new(4, "Buat Lara");
        public static readonly EkaJalaRsi BUAT_MERANG = new(5, "Buat Merang");
        public static readonly EkaJalaRsi BUAT_SEBET = new(6, "Buat Sebet");
        public static readonly EkaJalaRsi BUAT_SUKA = new(7, "Buat Suka");
        public static readonly EkaJalaRsi DAHAT_KINGKING = new(8, "Dahat Kingking");
        public static readonly EkaJalaRsi KAMERANAN = new(9, "Kameranan");
        public static readonly EkaJalaRsi KAMERTAAN = new(10, "Kamertaan");
        public static readonly EkaJalaRsi KASOBAGIAN = new(11, "Kasobagian");
        public static readonly EkaJalaRsi KINASIHAN_AMERTA = new(12, "Kinasihan Amerta");
        public static readonly EkaJalaRsi KINASIHAN_JANA = new(13, "Kinasihan Jana");
        public static readonly EkaJalaRsi LANGGENG_KAYOHANAAN = new(14, "Langgeng Kayohanaan");
        public static readonly EkaJalaRsi LUWIH_BAGIA = new(15, "Luwih Bagia");
        public static readonly EkaJalaRsi MANGGIH_BAGIA = new(16, "Manggih Bagia");
        public static readonly EkaJalaRsi MANGGIH_SUKA = new(17, "Manggih Suka");
        public static readonly EkaJalaRsi PATINING_AMERTA = new(18, "Patining Amerta");
        public static readonly EkaJalaRsi RAHAYU = new(19, "Rahayu");
        public static readonly EkaJalaRsi SIDHA_KASOBAGIAN = new(20, "Sidha Kasobagian");
        public static readonly EkaJalaRsi SUBAGIA = new(21, "Subagia");
        public static readonly EkaJalaRsi SUKA_KAPANGGIH = new(22, "Suka Kapanggih");
        public static readonly EkaJalaRsi SUKA_PINANGGIH = new(23, "Suka Pinanggih");
        public static readonly EkaJalaRsi SUKA_RAHAYU = new(24, "Suka Rahayu");
        public static readonly EkaJalaRsi TININGGALING_SUKA = new(25, "Tininggaling Suka");
        public static readonly EkaJalaRsi WERDHI_PUTRA = new(26, "Werdhi Putra");
        public static readonly EkaJalaRsi WERDHI_SARWA_MULE = new(27, "Werdhi Sarwa Mule");

        public static readonly EkaJalaRsi[] Values =
        {
            BAGNA_MAPASAH,
            BAHU_PUTRA,
            BUAT_ASTAWA,
            BUAT_KINGKING,
            BUAT_LARA,
            BUAT_MERANG,
            BUAT_SEBET,
            BUAT_SUKA,
            DAHAT_KINGKING,
            KAMERANAN,
            KAMERTAAN,
            KASOBAGIAN,
            KINASIHAN_AMERTA,
            KINASIHAN_JANA,
            LANGGENG_KAYOHANAAN,
            LUWIH_BAGIA,
            MANGGIH_BAGIA,
            MANGGIH_SUKA,
            PATINING_AMERTA,
            RAHAYU,
            SIDHA_KASOBAGIAN,
            SUBAGIA,
            SUKA_KAPANGGIH,
            SUKA_PINANGGIH,
            SUKA_RAHAYU,
            TININGGALING_SUKA,
            WERDHI_PUTRA,
            WERDHI_SARWA_MULE
        };

        public override string ToString() => Name;
        public static bool operator ==(EkaJalaRsi left, EkaJalaRsi right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            return left.Id == right.Id;
        }
        public static bool operator !=(EkaJalaRsi left, EkaJalaRsi right) => !(left == right);
        public override bool Equals(object obj) => obj is EkaJalaRsi other && this == other;
        public override int GetHashCode() => Id;
    }
}