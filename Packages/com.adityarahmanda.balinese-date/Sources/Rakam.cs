namespace BalineseCalendar
{
    public struct Rakam
    {
        public int Id { get; }
        public string Name { get; }

        private Rakam(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static readonly Rakam NUJU_PATI = new(0, "Nuju Pati");
        public static readonly Rakam KALA_TINANTANG = new(1, "Kala Tinantang");
        public static readonly Rakam DEMANG_KANDHURUWAN = new(2, "Demang Kandhuruwan");
        public static readonly Rakam SANGGAR_WARINGIN = new(3, "Sanggar Waringin");
        public static readonly Rakam MANTRI_SINAROJA = new(4, "Mantri Sinaroja");
        public static readonly Rakam MACAN_KATAWAN = new(5, "Macan Katawan");

        public static readonly Rakam[] Values =
        {
            NUJU_PATI,
            KALA_TINANTANG,
            DEMANG_KANDHURUWAN,
            SANGGAR_WARINGIN,
            MANTRI_SINAROJA,
            MACAN_KATAWAN
        };

        public override string ToString() => Name;

        public static bool operator ==(Rakam left, Rakam right) => left.Id == right.Id;
        public static bool operator !=(Rakam left, Rakam right) => left.Id != right.Id;

        public override bool Equals(object obj) => obj is Rakam other && this == other;
        public override int GetHashCode() => Id;
    }
}