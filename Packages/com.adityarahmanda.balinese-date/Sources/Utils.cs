using System;
using System.Collections.Generic;

namespace BalineseCalendar
{
    public static class Utils
    {
        public static BalineseDate ToBalineseDate(this DateTime dateTime) => new(dateTime);

        public static List<BalineseDate> FilterByDateRange(DateTime start, DateTime end, Filter filter = null)
        {
            var result = new List<BalineseDate>();
            var now = start;
            while ((end - now).TotalDays >= 0)
            {
                var x = new BalineseDate(now);

                if (FilterByItem(x, filter))
                    result.Add(x);

                now = now.AddDays(1);
            }
            return result;
        }

        public static List<BalineseDate> FilterByList(List<BalineseDate> list, Filter filter = null)
        {
            var result = new List<BalineseDate>();
            foreach (var item in list)
            {
                if (FilterByItem(item, filter))
                    result.Add(item);
            }
            return result;
        }

        public static bool FilterByItem(BalineseDate item, Filter filter = null)
        {
            if (filter != null)
            {
                if (!FilterCheck(filter.wuku, item.wuku)) return false;
                if (!FilterCheck(filter.ekaWara, item.ekaWara)) return false;
                if (!FilterCheck(filter.dwiWara, item.dwiWara)) return false;
                if (!FilterCheck(filter.triWara, item.triWara)) return false;
                if (!FilterCheck(filter.caturWara, item.caturWara)) return false;
                if (!FilterCheck(filter.pancaWara, item.pancaWara)) return false;
                if (!FilterCheck(filter.sadWara, item.sadWara)) return false;
                if (!FilterCheck(filter.saptaWara, item.saptaWara)) return false;
                if (!FilterCheck(filter.astaWara, item.astaWara)) return false;
                if (!FilterCheck(filter.sangaWara, item.sangaWara)) return false;
                if (!FilterCheck(filter.dasaWara, item.dasaWara)) return false;
                if (!FilterCheck(filter.ingkel, item.ingkel)) return false;
                if (!FilterCheck(filter.jejepan, item.jejepan)) return false;
                if (!FilterCheck(filter.watekAlit, item.watekAlit)) return false;
                if (!FilterCheck(filter.watekMadya, item.watekMadya)) return false;
                if (!FilterCheck(filter.lintang, item.lintang)) return false;
                if (!FilterCheck(filter.pancaSuda, item.pancaSuda)) return false;
                if (!FilterCheck(filter.pararasan, item.pararasan)) return false;
                if (!FilterCheck(filter.rakam, item.rakam)) return false;
                if (!FilterCheck(filter.ekaJalaRsi, item.ekaJalaRsi)) return false;
                if (!FilterCheck(filter.saka, item.saka)) return false;
                if (!FilterCheck(filter.sasih, item.sasih)) return false;
                if (!FilterCheck(filter.pratithiSamutPada, item.pratithiSamutPada)) return false;
                if (!FilterCheckSasihDay(filter.sasihDay, item.sasihDay)) return false;
                if (!FilterCheckSasihDayInfo(filter.sasihDayInfo, item.sasihDayInfo)) return false;
            }
            return true;
        }

        private static bool ArrayCheck(int[] a, IReadOnlyList<int> b)
        {
            if (a.Length == b.Count)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i])
                        return false;
                }
                return true;
            }
            return false;
        }

        private static bool FilterCheck<T>(T expectation, T reality)
        {
            if (expectation == null)
                return true;
            return EqualityComparer<T>.Default.Equals(expectation, reality);
        }

        private static bool FilterCheckSasihDay(int[] expectation, IReadOnlyList<int> reality)
        {
            if (expectation != null)
            {
                switch (expectation.Length)
                {
                    case 1:
                        if (reality.Count == 1)
                            return expectation[0] == reality[0];

                        if (reality.Count == 2)
                            return expectation[0] == reality[0] || expectation[0] == reality[1];

                        return false;

                    case 2:
                        return reality.Count == 2 && ArrayCheck(expectation, reality);

                    default:
                        return false;
                }
            }

            return true;
        }

        private static bool FilterCheckSasihDayInfo(SasihDayInfo expectation, SasihDayInfo reality)
        {
            if (expectation == null) return true;
            if (expectation == SasihDayInfo.PURNAMA || expectation == SasihDayInfo.TILEM)
                return expectation == reality;
            return expectation == reality.Reference;
        }
        
        public static List<Rahinan> GetRahinan(this BalineseDate date)
        {
            return CalculateRahinan(date);
        }

        private static List<Rahinan> CalculateRahinan(BalineseDate date)
        {
            var arr = new List<Rahinan>();
            if (date.triWara == TriWara.KAJENG && date.pancaWara == PancaWara.KLIWON)
                arr.Add(Rahinan.KAJENG_KLIWON);
            if (date.saptaWara == SaptaWara.ANGGARA && date.pancaWara == PancaWara.KLIWON)
                arr.Add(Rahinan.ANGGARA_KASIH);
            else if (date.saptaWara == SaptaWara.BUDA && date.pancaWara == PancaWara.WAGE)
                arr.Add(Rahinan.BUDA_CEMENG);
            
            if (date.wuku == Wuku.SINTA)
            {
                if (date.saptaWara == SaptaWara.REDITE)
                    arr.Add(Rahinan.BANYU_PINARUH);
                else if (date.saptaWara == SaptaWara.SOMA)
                    arr.Add(Rahinan.SOMA_RIBEK);
                else if (date.saptaWara == SaptaWara.ANGGARA)
                    arr.Add(Rahinan.SABUH_EMAS);
                else if (date.saptaWara == SaptaWara.BUDA)
                    arr.Add(Rahinan.PAGER_WESI);
            }
            
            if (date.wuku == Wuku.LANDEP && date.saptaWara == SaptaWara.SANISCARA)
                arr.Add(Rahinan.TUMPEK_LANDEP);
            if (date.wuku == Wuku.WARIGA && date.saptaWara == SaptaWara.SANISCARA)
                arr.Add(Rahinan.TUMPEK_UDUH);
            if (date.wuku == Wuku.WATUGUNUNG && date.saptaWara == SaptaWara.SANISCARA)
                arr.Add(Rahinan.SARASWATI);

            var temp = date.date;
            var n1Day = new BalineseDate(temp.AddDays(1));
            var b1Day = new BalineseDate(temp.AddDays(-1));
            var b2Day = new BalineseDate(temp.AddDays(-2));

            if (n1Day.sasih == Sasih.KAPITU && n1Day.sasihDayInfo == SasihDayInfo.TILEM)
                arr.Add(Rahinan.SIWA_RATRI);
            else if (date.saka < n1Day.saka)
                arr.Add(Rahinan.TAWUR_AGUNG_KASANGA);
            else if (b1Day.saka < date.saka)
                arr.Add(Rahinan.NYEPI);
            else if (b2Day.saka < date.saka && b1Day.saka == date.saka)
                arr.Add(Rahinan.NGEMBAK_GENI);

            if (date.sasihDayInfo == SasihDayInfo.PURNAMA)
                arr.Add(Rahinan.PURNAMA);
            else if (date.sasihDayInfo == SasihDayInfo.TILEM)
                arr.Add(Rahinan.TILEM);

            return arr;
        }
    }
}