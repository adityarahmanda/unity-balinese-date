using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

namespace BalineseCalendar
{
    public static class Utils
    {
        private static readonly Regex SplitCommaOutsideQuotes = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

        private static DewasaDatabase DewasaDatabase
        {
            get
            {
                if (_dewasaDatabase != null) return _dewasaDatabase;
                
                _dewasaDatabase = Resources.Load<DewasaDatabase>(DewasaDatabase.DewasaDatabasePath);
                if (_dewasaDatabase == null)
                    Debug.LogError($"Failed to load {nameof(BalineseCalendar.DewasaDatabase)} from path: {DewasaDatabase.DewasaDatabasePath}");
                return _dewasaDatabase;
            }
        }
    
        private static DewasaDatabase _dewasaDatabase = null;
        
        private static SasihDatabase SasihDatabase
        {
            get
            {
                if (_sasihDatabase != null) return _sasihDatabase;
                
                _sasihDatabase = Resources.Load<SasihDatabase>(SasihDatabase.SasihDatabasePath);
                if (_sasihDatabase == null)
                    Debug.LogError($"Failed to load {nameof(BalineseCalendar.SasihDatabase)} from path: {SasihDatabase.SasihDatabasePath}");
                return _sasihDatabase;
            }
        }
    
        private static SasihDatabase _sasihDatabase = null;

        public static BalineseDate ToBalineseDate(this DateTime dateTime) => new(dateTime);

        public static List<BalineseDate> FilterByDateRange(DateTime start, DateTime end, Filter filter = null)
        {
            var result = new List<BalineseDate>();
            var now = start;
            while ((end - now).TotalDays >= 0)
            {
                var x = new BalineseDate(now);

                if (FilterByDateItem(x, filter))
                    result.Add(x);

                now = now.AddDays(1);
            }
            return result;
        }
        
        public static List<BalineseDate> FilterByDateList(List<BalineseDate> list, Filter filter = null)
        {
            var result = new List<BalineseDate>();
            foreach (var item in list)
            {
                if (FilterByDateItem(item, filter))
                    result.Add(item);
            }
            return result;
        }
        
        public static List<BalineseDate> FilterCheckDewasaByDateList(List<BalineseDate> list, params Dewasa[] dewasaList)
        {
            if (DewasaDatabase == null) return new List<BalineseDate>();
            
            var ruleNameList = new HashSet<string>();
            foreach (var dewasa in dewasaList)
            {
                var dewasaData = DewasaDatabase.GetDewasaData(dewasa);
                if (dewasaData == null) continue;

                foreach (var ruleName in dewasaData.RuleNameList)
                    ruleNameList.Add(ruleName);
            }

            var result = new List<BalineseDate>();
            foreach (var item in list)
            {
                foreach (var ruleName in ruleNameList)
                {
                    if (DewasaDatabase.FilterCheckByDewasaRule(item, ruleName))
                        result.Add(item);
                }
            }
            
            return result;
        }

        public static bool FilterByDateItem(BalineseDate item, Filter filter = null)
        {
            if (filter == null) return false;
            
            var validList = new List<bool>();
            if (filter.wuku != null) 
                validList.Add(FilterCheck(filter.wuku, item.wuku));
            if (filter.ekaWara != null)
                validList.Add(FilterCheck(filter.ekaWara, item.ekaWara));
            if (filter.dwiWara != null)
                validList.Add(FilterCheck(filter.dwiWara, item.dwiWara));
            if (filter.triWara != null)
                validList.Add(FilterCheck(filter.triWara, item.triWara));
            if (filter.caturWara != null)
                validList.Add(FilterCheck(filter.caturWara, item.caturWara));
            if (filter.pancaWara != null)
                validList.Add(FilterCheck(filter.pancaWara, item.pancaWara));
            if (filter.sadWara != null)
                validList.Add(FilterCheck(filter.sadWara, item.sadWara));
            if (filter.saptaWara != null)
                validList.Add(FilterCheck(filter.saptaWara, item.saptaWara));
            if (filter.astaWara != null)
                validList.Add(FilterCheck(filter.astaWara, item.astaWara));
            if (filter.sangaWara != null)
                validList.Add(FilterCheck(filter.sangaWara, item.sangaWara));
            if (filter.dasaWara != null)
                validList.Add(FilterCheck(filter.dasaWara, item.dasaWara));
            if (filter.ingkel != null)
                validList.Add(FilterCheck(filter.ingkel, item.ingkel));
            if (filter.jejepan != null)
                validList.Add(FilterCheck(filter.jejepan, item.jejepan));
            if (filter.lintang != null)
                validList.Add(FilterCheck(filter.lintang, item.lintang));
            if (filter.pancaSuda != null)
                validList.Add(FilterCheck(filter.pancaSuda, item.pancaSuda));
            if (filter.pararasan != null)
                validList.Add(FilterCheck(filter.pararasan, item.pararasan));
            if (filter.watekAlit != null)
                validList.Add(FilterCheck(filter.watekAlit, item.watekAlit));
            if (filter.watekMadya != null)
                validList.Add(FilterCheck(filter.watekMadya, item.watekMadya));
            if (filter.rakam != null)
                validList.Add(FilterCheck(filter.rakam, item.rakam));
            if (filter.ekaJalaRsi != null)
                validList.Add(FilterCheck(filter.ekaJalaRsi, item.ekaJalaRsi));
            if (filter.pratithiSamutPada != null)
                validList.Add(FilterCheck(filter.pratithiSamutPada, item.pratithiSamutPada));
            if (filter.sasih != null)
                validList.Add(FilterCheck(filter.sasih, item.sasih));
            if (filter.sasihDay != null && filter.sasihDay.Length > 0)
                validList.Add(FilterCheckSasihDay(filter.sasihDay, item.sasihDay));
            if (filter.sasihDayInfo != null)
                validList.Add(FilterCheckSasihDayInfo(filter.sasihDayInfo, item.sasihDayInfo));
            if (filter.saka >= 0)
                validList.Add(FilterCheck(filter.saka, item.saka));
            
            if (validList.Count == 0) return false;
            foreach (var valid in validList)
                if (!valid) return false;
            return true;
        }

        private static bool FilterCheckDewasa(Dewasa filterDewasa, List<Dewasa> dateDewasaList)
        {
            foreach (var dewasa in dateDewasaList)
                if (dewasa == filterDewasa) return true;
            return false;
        }
        
        private static bool ArrayCheck(Dewasa[] a, IReadOnlyList<Dewasa> b)
        {
            if (a.Length != b.Count) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }

        private static bool ArrayCheck(int[] a, IReadOnlyList<int> b)
        {
            if (a.Length != b.Count) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }

        private static bool FilterCheck<T>(T expectation, T reality)
        {
            if (expectation == null) return false;
            return EqualityComparer<T>.Default.Equals(expectation, reality);
        }

        private static bool FilterCheckSasihDay(int[] expectation, IReadOnlyList<int> reality)
        {
            if (expectation == null) return false;
            
            switch (expectation.Length)
            {
                case 1:
                    if (reality.Count == 1)
                        return expectation[0] == reality[0];

                    if (reality.Count == 2)
                        return expectation[0] == reality[1];

                    return false;

                case 2:
                    return reality.Count == 2 && ArrayCheck(expectation, reality);

                default:
                    return false;
            }
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
            if (date.triWara == TriWara.KAJENG && date.pancaWara == PancaWara.KELIWON)
                arr.Add(Rahinan.KAJENG_KLIWON);
            if (date.saptaWara == SaptaWara.ANGGARA && date.pancaWara == PancaWara.KELIWON)
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
        
        public static List<Dewasa> GetDewasa(this BalineseDate balineseDate)
        {
            if (DewasaDatabase == null) return new List<Dewasa>();
            return DewasaDatabase.GetDewasa(balineseDate);
        }

        public static DewasaData GetDewasaData(this Dewasa dewasa)
        {
            if (DewasaDatabase == null) return null;
            return DewasaDatabase.GetDewasaData(dewasa);
        }
        
        public static SasihData GetSasihData(this Sasih sasih)
        {
            if (SasihDatabase == null) return null;
            return SasihDatabase.GetSasihData(sasih);
        }

        public static string[] SplitOutsideQuotes(string input)
        {
            if (string.IsNullOrEmpty(input))
                return Array.Empty<string>();
            
            return SplitCommaOutsideQuotes
                .Split(input)
                .Select(x => x.Trim().Trim('"')) // remove spaces + quotes
                .Where(x => !string.IsNullOrEmpty(x))
                .ToArray();
        }
    }
}