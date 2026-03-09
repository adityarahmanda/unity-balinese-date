namespace BalineseCalendar
{
    public struct EkaWara
    {
        public int Id { get; }
        public int Urip { get; }
        public string Name { get; }

        private EkaWara(int id, int urip, string name)
        {
            Id = id;
            Urip = urip;
            Name = name;
        }

        public static readonly EkaWara VOID = new(0, 0, "");
        public static readonly EkaWara LUANG = new(1, 1, "Luang");

        public static readonly EkaWara[] Values =
        {
            VOID,
            LUANG
        };

        public override string ToString() => Name;

        public static bool operator ==(EkaWara left, EkaWara right) => left.Id == right.Id;
        public static bool operator !=(EkaWara left, EkaWara right) => left.Id != right.Id;

        public override bool Equals(object obj) => obj is EkaWara other && this == other;
        public override int GetHashCode() => Id;
    }
}