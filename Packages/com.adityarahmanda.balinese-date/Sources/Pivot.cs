using System;

namespace BalineseCalendar
{
    public struct Pivot
    {
        public DateTime Date { get; }
        public int PawukonDay { get; }
        public int SasihDay { get; }
        public int NgunaRatriDay { get; }
        public int Saka { get; }
        public Sasih Sasih { get; }
        public bool IsNampihSasih { get; }

        public Pivot(DateTime date, int pawukonDay, int sasihDay, int ngunaRatriDay, int saka, Sasih sasih, bool isNampihSasih)
        {
            Date = date;
            PawukonDay = pawukonDay;
            SasihDay = sasihDay;
            NgunaRatriDay = ngunaRatriDay;
            Saka = saka;
            Sasih = sasih;
            IsNampihSasih = isNampihSasih;
        }
        
        public static readonly Pivot PIVOT_1971 = new Pivot(new DateTime(1971, 1, 27), 3, 0, 0, 1892, Sasih.KAPITU, false);
        public static readonly Pivot PIVOT_2000 = new Pivot(new DateTime(2000, 1, 18), 86, 12, 0, 1921, Sasih.KAPITU, false);
    }
}