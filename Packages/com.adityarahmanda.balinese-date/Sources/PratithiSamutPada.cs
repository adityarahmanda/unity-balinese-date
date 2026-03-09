namespace BalineseCalendar
{
    public sealed class PratithiSamutPada
    {
        public int Id { get; }
        public string Name { get; }

        private PratithiSamutPada(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static readonly PratithiSamutPada TRESNA = new(0, "Tresna");
        public static readonly PratithiSamutPada UPADANA = new(1, "Upadana");
        public static readonly PratithiSamutPada BHAWA = new(2, "Bhawa");
        public static readonly PratithiSamutPada JATI = new(3, "Jati");
        public static readonly PratithiSamutPada JARAMARANA = new(4, "Jaramarana");
        public static readonly PratithiSamutPada AWIDYA = new(5, "Awidya");
        public static readonly PratithiSamutPada SASKARA = new(6, "Saskara");
        public static readonly PratithiSamutPada WIDNYANA = new(7, "Widnyana");
        public static readonly PratithiSamutPada NAMARUPA = new(8, "Namarupa");
        public static readonly PratithiSamutPada SADAYATANA = new(9, "Sadayatana");
        public static readonly PratithiSamutPada SEPARSA = new(10, "Separsa");
        public static readonly PratithiSamutPada WEDANA = new(11, "Wedana");

        public static readonly PratithiSamutPada[] Values =
        {
            TRESNA,
            UPADANA,
            BHAWA,
            JATI,
            JARAMARANA,
            AWIDYA,
            SASKARA,
            WIDNYANA,
            NAMARUPA,
            SADAYATANA,
            SEPARSA,
            WEDANA
        };

        public override string ToString() => Name;
        public static bool operator ==(PratithiSamutPada left, PratithiSamutPada right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            return left.Id == right.Id;
        }
        public static bool operator !=(PratithiSamutPada left, PratithiSamutPada right) => !(left == right);
        public override bool Equals(object obj) => obj is PratithiSamutPada other && this == other;
        public override int GetHashCode() => Id;
    }
}