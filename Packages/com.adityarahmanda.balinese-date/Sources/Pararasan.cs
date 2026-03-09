namespace BalineseCalendar
{
    public sealed class Pararasan
    {
        public int Id { get; }
        public string Name { get; }

        private Pararasan(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static readonly Pararasan LAKU_PANDITA_SAKTI = new Pararasan(0, "Laku Pandita Sakti");
        public static readonly Pararasan ARAS_TUDING = new Pararasan(1, "Aras Tuding");
        public static readonly Pararasan ARAS_KEMBANG = new Pararasan(2, "Aras Kembang");
        public static readonly Pararasan LAKU_BINTANG = new Pararasan(3, "Laku Bintang");
        public static readonly Pararasan LAKU_BULAN = new Pararasan(4, "Laku Bulan");
        public static readonly Pararasan LAKU_SURYA = new Pararasan(5, "Laku Surya");
        public static readonly Pararasan LAKU_AIR = new Pararasan(6, "Laku Air");
        public static readonly Pararasan LAKU_BUMI = new Pararasan(7, "Laku Bumi");
        public static readonly Pararasan LAKU_API = new Pararasan(8, "Laku Api");
        public static readonly Pararasan LAKU_ANGIN = new Pararasan(9, "Laku Angin");

        public static readonly Pararasan[] Values =
        {
            LAKU_PANDITA_SAKTI,
            ARAS_TUDING,
            ARAS_KEMBANG,
            LAKU_BINTANG,
            LAKU_BULAN,
            LAKU_SURYA,
            LAKU_AIR,
            LAKU_BUMI,
            LAKU_API,
            LAKU_ANGIN
        };

        public override string ToString() => Name;
        public static bool operator ==(Pararasan left, Pararasan right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            return left.Id == right.Id;
        }
        public static bool operator !=(Pararasan left, Pararasan right) => !(left == right);
        public override bool Equals(object obj) => obj is Pararasan other && this == other;
        public override int GetHashCode() => Id;
    }
}