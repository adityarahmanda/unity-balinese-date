namespace BalineseCalendar
{
    public struct PancaSuda
    {
        public int Id { get; }
        public string Name { get; }
    
        private PancaSuda(int id, string name)
        {
            Id = id;
            Name = name;
        }
    
        public static readonly PancaSuda LEBU_KATIUB_ANGIN = new PancaSuda(0, "Lebu Katiup Angin");
        public static readonly PancaSuda WISESA_SEGARA = new PancaSuda(1, "Wisesa Segara");
        public static readonly PancaSuda TUNGGAK_SEMI = new PancaSuda(2, "Tunggak Semi");
        public static readonly PancaSuda SATRIA_WIBAWA = new PancaSuda(3, "Satria Wibawa");
        public static readonly PancaSuda SUMUR_SINABA = new PancaSuda(4, "Sumur Sinaba");
        public static readonly PancaSuda SATRIA_WIRANG = new PancaSuda(5, "Satria Wirang");
        public static readonly PancaSuda BUMI_KAPETAK = new PancaSuda(6, "Bumi Kapetak");
    
        public static readonly PancaSuda[] Values =
        {
            LEBU_KATIUB_ANGIN,
            WISESA_SEGARA,
            TUNGGAK_SEMI,
            SATRIA_WIBAWA,
            SUMUR_SINABA,
            SATRIA_WIRANG,
            BUMI_KAPETAK
        };
        
        public override string ToString() => Name;
        
        public static bool operator ==(PancaSuda left, PancaSuda right) => left.Id == right.Id;
        public static bool operator !=(PancaSuda left, PancaSuda right) => left.Id != right.Id;

        public override bool Equals(object obj) => obj is PancaSuda other && this == other;
        public override int GetHashCode() => Id;
    }
}