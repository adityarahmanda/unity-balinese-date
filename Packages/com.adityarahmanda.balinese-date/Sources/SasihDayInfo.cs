namespace BalineseCalendar
{
    public sealed class SasihDayInfo
    {
        public int Id { get; }
        public int RefId { get; }
        public string Name { get; }
    
        private SasihDayInfo(int id, int refId, string name)
        {
            Id = id;
            RefId = refId;
            Name = name;
        }
    
        public static SasihDayInfo PENANGGAL => new SasihDayInfo(0, 0, "Penanggal");
        public static SasihDayInfo PANGELONG => new SasihDayInfo(1, 1, "Pangelong");
        public static SasihDayInfo PURNAMA => new SasihDayInfo(2, 0, "Purnama");
        public static SasihDayInfo TILEM => new SasihDayInfo(3, 1, "Tilem");
        
        public SasihDayInfo Reference => Values[RefId];
        
        public static readonly SasihDayInfo[] Values =
        {
            PENANGGAL,
            PANGELONG,
            PURNAMA,
            TILEM
        };
        
        public override string ToString() => Name;
        public static bool operator ==(SasihDayInfo left, SasihDayInfo right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            return left.Id == right.Id;
        }
        public static bool operator !=(SasihDayInfo left, SasihDayInfo right) => !(left == right);
        public override bool Equals(object obj) => obj is SasihDayInfo other && this == other;
        public override int GetHashCode() => Id;
    }
}