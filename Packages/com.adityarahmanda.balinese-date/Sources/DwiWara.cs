namespace BalineseCalendar
{
    public struct DwiWara
    {
        public int Id { get; }
        public int Urip { get; }
        public string Name { get; }

        private DwiWara(int id, int urip, string name)
        {
            Id = id;
            Urip = urip;
            Name = name;
        }

        public static readonly DwiWara MENGA = new(0, 5, "Menga");
        public static readonly DwiWara PEPET = new(1, 4, "Pepet");

        public static readonly DwiWara[] Values =
        {
            MENGA,
            PEPET
        };

        public override string ToString() => Name;

        public static bool operator ==(DwiWara left, DwiWara right) => left.Id == right.Id;
        public static bool operator !=(DwiWara left, DwiWara right) => left.Id != right.Id;

        public override bool Equals(object obj) => obj is DwiWara other && this == other;
        public override int GetHashCode() => Id;
    }
}