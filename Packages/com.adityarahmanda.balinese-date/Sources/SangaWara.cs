namespace BalineseCalendar
{
    public struct SangaWara
    {
        public int Id { get; }
        public int Urip { get; }
        public string Name { get; }

        private SangaWara(int id, int urip, string name)
        {
            Id = id;
            Urip = urip;
            Name = name;
        }

        public static readonly SangaWara DANGU = new(0, 5, "Dangu");
        public static readonly SangaWara JANGUR = new(1, 8, "Jangur");
        public static readonly SangaWara GIGIS = new(2, 9, "Gigis");
        public static readonly SangaWara NOHAN = new(3, 3, "Nohan");
        public static readonly SangaWara OGAN = new(4, 7, "Ogan");
        public static readonly SangaWara ERANGAN = new(5, 1, "Erangan");
        public static readonly SangaWara URUNGAN = new(6, 4, "Urungan");
        public static readonly SangaWara TULUS = new(7, 6, "Tulus");
        public static readonly SangaWara DADI = new(8, 8, "Dadi");

        public static readonly SangaWara[] Values =
        {
            DANGU,
            JANGUR,
            GIGIS,
            NOHAN,
            OGAN,
            ERANGAN,
            URUNGAN,
            TULUS,
            DADI
        };

        public override string ToString() => Name;

        public static bool operator ==(SangaWara left, SangaWara right) => left.Id == right.Id;
        public static bool operator !=(SangaWara left, SangaWara right) => left.Id != right.Id;

        public override bool Equals(object obj) => obj is SangaWara other && this == other;
        public override int GetHashCode() => Id;
    }
}