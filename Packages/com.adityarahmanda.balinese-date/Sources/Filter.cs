namespace BalineseCalendar
{
    public class Filter
    {
        public EkaWara ekaWara { get; set; }
        public DwiWara dwiWara { get; set; }
        public TriWara triWara { get; set; }
        public CaturWara caturWara { get; set; }
        public PancaWara pancaWara { get; set; }
        public SadWara sadWara { get; set; }
        public SaptaWara saptaWara { get; set; }
        public AstaWara astaWara { get; set; }
        public SangaWara sangaWara { get; set; }
        public DasaWara dasaWara { get; set; }
        public Ingkel ingkel { get; set; }
        public Jejepan jejepan { get; set; }
        public Lintang lintang { get; set; }
        public PancaSuda pancaSuda { get; set; }
        public Pararasan pararasan { get; set; }
        public WatekAlit watekAlit { get; set; }
        public WatekMadya watekMadya { get; set; }
        public Rakam rakam { get; set; }
        public EkaJalaRsi ekaJalaRsi { get; set; }
        public Wuku wuku { get; set; }
        public Sasih sasih { get; set; }
        public SasihDayInfo sasihDayInfo { get; set; }
        public int[] sasihDay { get; set; }
        public int? saka { get; set; }
        public PratithiSamutPada pratithiSamutPada { get; set; }

        public Filter()
        {
            ekaWara = null;
            dwiWara = null;
            triWara = null;
            caturWara = null;
            pancaWara = null;
            sadWara = null;
            saptaWara = null;
            astaWara = null;
            sangaWara = null;
            dasaWara = null;
            ingkel = null;
            jejepan = null;
            lintang = null;
            pancaSuda = null;
            pararasan = null;
            watekAlit = null;
            watekMadya = null;
            rakam = null;
            ekaJalaRsi = null;
            wuku = null;
            sasih = null;
            sasihDayInfo = null;
            sasihDay = null;
            saka = null;
            pratithiSamutPada = null;
        }
    }
}