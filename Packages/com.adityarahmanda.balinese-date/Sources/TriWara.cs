namespace BalineseCalendar
{
    public struct TriWara
    {
        public int Id { get; }
        public int Urip { get; }
        public string Name { get; }

        private TriWara(int id, int urip, string name)
        {
            Id = id;
            Urip = urip;
            Name = name;
        }

        public static readonly TriWara PASAH = new(0, 9, "Pasah");
        public static readonly TriWara BETENG = new(1, 4, "Beteng");
        public static readonly TriWara KAJENG = new(2, 7, "Kajeng");

        public static readonly TriWara[] Values =
        {
            PASAH,
            BETENG,
            KAJENG
        };

        public override string ToString() => Name;

        public static bool operator ==(TriWara left, TriWara right) => left.Id == right.Id;
        public static bool operator !=(TriWara left, TriWara right) => left.Id != right.Id;

        public override bool Equals(object obj) => obj is TriWara other && this == other;
        public override int GetHashCode() => Id;
    }
}