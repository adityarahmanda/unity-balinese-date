namespace BalineseCalendar
{
    public sealed class DasaWara
    {
        public int Id { get; }
        public int Urip { get; }
        public string Name { get; }

        private DasaWara(int id, int urip, string name)
        {
            Id = id;
            Urip = urip;
            Name = name;
        }

        public static readonly DasaWara PANDITA = new(0, 5, "Pandita");
        public static readonly DasaWara PATI = new(1, 7, "Pati");
        public static readonly DasaWara SUKA = new(2, 10, "Suka");
        public static readonly DasaWara DUKA = new(3, 4, "Duka");
        public static readonly DasaWara SRI = new(4, 6, "Sri");
        public static readonly DasaWara MANUH = new(5, 2, "Manuh");
        public static readonly DasaWara MANUSA = new(6, 3, "Manusa");
        public static readonly DasaWara RAJA = new(7, 8, "Raja");
        public static readonly DasaWara DEWA = new(8, 9, "Dewa");
        public static readonly DasaWara RAKSASA = new(9, 1, "Raksasa");

        public static readonly DasaWara[] Values =
        {
            PANDITA,
            PATI,
            SUKA,
            DUKA,
            SRI,
            MANUH,
            MANUSA,
            RAJA,
            DEWA,
            RAKSASA
        };

        public override string ToString() => Name;
        public static bool operator ==(DasaWara left, DasaWara right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            return left.Id == right.Id;
        }
        public static bool operator !=(DasaWara left, DasaWara right) => !(left == right);
        public override bool Equals(object obj) => obj is DasaWara other && this == other;
        public override int GetHashCode() => Id;
    }
}