namespace BalineseCalendar
{
    public sealed class Sasih
    {
        public int Id { get; }
        public int RefId { get; }
        public string Name { get; }
        
        public Sasih Reference => Values[RefId];

        private Sasih(int id, int refId, string name)
        {
            Id = id;
            RefId = refId;
            Name = name;
        }
        
        public static readonly Sasih KASA = new(0, 0, "Kasa");
        public static readonly Sasih KARO = new(1, 1, "Karo");
        public static readonly Sasih KATIGA = new(2, 2, "Katiga");
        public static readonly Sasih KAPAT = new(3, 3, "Kapat");
        public static readonly Sasih KALIMA = new(4, 4, "Kalima");
        public static readonly Sasih KANEM = new(5, 5, "Kanem");
        public static readonly Sasih KAPITU = new(6, 6, "Kapitu");
        public static readonly Sasih KAWOLU = new(7, 7, "Kawolu");
        public static readonly Sasih KASANGA = new(8, 8, "Kasanga");
        public static readonly Sasih KADASA = new(9, 9, "Kadasa");
        public static readonly Sasih DESTHA = new(10, 10, "Destha");
        public static readonly Sasih SADHA = new(11, 11, "Sadha");
        public static readonly Sasih MALA_DESTHA = new(12, 10, "Mala Destha");
        public static readonly Sasih MALA_SADHA = new(13, 11, "Mala Sadha");
        public static readonly Sasih NAMPIH_DESTHA = new(14, 10, "Nampih Destha");
        public static readonly Sasih NAMPIH_KATIGA = new(15, 2, "Nampih Katiga");
        public static readonly Sasih NAMPIH_KASA = new(16, 0, "Nampih Kasa");
        public static readonly Sasih NAMPIH_KADASA = new(17, 9, "Nampih Kadasa");
        public static readonly Sasih NAMPIH_KARO = new(18, 1, "Nampih Karo");
        public static readonly Sasih NAMPIH_SADHA = new(19, 11, "Nampih Sadha");
        
        public static readonly Sasih[] Values =
        {
            KASA,
            KARO,
            KATIGA,
            KAPAT,
            KALIMA,
            KANEM,
            KAPITU,
            KAWOLU,
            KASANGA,
            KADASA,
            DESTHA,
            SADHA,
            MALA_DESTHA,
            MALA_SADHA,
            NAMPIH_DESTHA,
            NAMPIH_KATIGA,
            NAMPIH_KASA,
            NAMPIH_KADASA,
            NAMPIH_KARO,
            NAMPIH_SADHA
        };
        
        public override string ToString() => Name;
        public static bool operator ==(Sasih left, Sasih right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            return left.Id == right.Id;
        }
        public static bool operator !=(Sasih left, Sasih right) => !(left == right);
        public override bool Equals(object obj) => obj is Sasih other && this == other;
        public override int GetHashCode() => Id;
    }
}