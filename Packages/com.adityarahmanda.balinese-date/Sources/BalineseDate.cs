using System;
using System.Collections.Generic;
using UnityEngine;

namespace BalineseCalendar
{
    public struct BalineseDate
    {
        public static BalineseDate Today => new BalineseDate(DateTime.Today);

        public DateTime date { get; private set; }
        public Wuku wuku { get; private set; }
        public EkaWara ekaWara { get; private set; }
        public DwiWara dwiWara { get; private set; }
        public TriWara triWara { get; private set; }
        public CaturWara caturWara { get; private set; }
        public PancaWara pancaWara { get; private set; }
        public SadWara sadWara { get; private set; }
        public SaptaWara saptaWara { get; private set; }
        public AstaWara astaWara { get; private set; }
        public SangaWara sangaWara { get; private set; }
        public DasaWara dasaWara { get; private set; }
        public Jejepan jejepan { get; private set; }
        public Lintang lintang { get; private set; }
        public PancaSuda pancaSuda { get; private set; }
        public Rakam rakam { get; private set; }
        public EkaJalaRsi ekaJalaRsi { get; private set; }
        public Ingkel ingkel { get; private set; }
        public WatekAlit watekAlit { get; private set; }
        public WatekMadya watekMadya { get; private set; }
        public Pararasan pararasan { get; private set; }
        public Sasih sasih { get; private set; }
        public int saka { get; private set; }
        public SasihDayInfo sasihDayInfo { get; private set; }
        public int[] sasihDay { get; private set; }
        public PratithiSamutPada pratithiSamutPada { get; private set; }
        public IReadOnlyList<Dewasa> dewasa { get; private set; }

        private const int DAY_PAWUKON = 210;
        private const int DAY_NGUNARATRI = 63;

        private static readonly DateTime PANGALANTAKA_PAING = new DateTime(2000, 1, 6);
        private static readonly DateTime SK_START = new DateTime(1993, 1, 24);
        private static readonly DateTime SK_END = new DateTime(2003, 1, 3);

        private static readonly int[] EJR_MAP = new int[]
        {
            23, 7, 17, 7, 23, 23, 17, 9, 7, 13, 26, 24, 23, 20, 13, 7, 13, 25, 19, 6, 2,
            14, 26, 17, 20, 25, 22, 0, 10, 6, 15, 23, 7, 17, 23, 17, 25, 5, 23, 2, 2, 2, 12, 12, 5, 14, 12, 26, 26, 1,
            23, 23, 15, 25, 15, 6, 9, 25, 18, 25, 11, 15, 21, 25, 25, 12, 0, 17, 13, 0, 15, 23, 12, 7, 16, 25, 18, 24,
            12, 12, 6, 7, 6, 26, 7, 6, 12, 7, 25, 2, 12, 25, 25, 14, 15, 26, 7, 12, 20, 7, 6, 25, 25, 6, 13, 25, 17, 13,
            23, 6, 26, 20, 25, 25, 23, 7, 18, 18, 17, 7, 17, 7, 5, 26, 17, 6, 9, 12, 12, 13, 25, 18, 18, 6, 2, 25, 25,
            2, 25, 17, 20, 14, 27, 23, 17, 8, 25, 17, 6, 17, 7, 3, 15, 18, 25, 2, 7, 13, 25, 20, 7, 15, 15, 23, 7, 8,
            24, 2, 12, 9, 24, 24, 17, 24, 20, 7, 12, 12, 14, 18, 25, 20, 5, 18, 5, 20, 26, 12, 23, 18, 17, 17, 25, 15,
            2, 24, 4, 2, 23, 25, 18, 25, 20, 14, 4, 2, 25, 7, 25, 17
        };

        public BalineseDate(DateTime dateRef)
        {
            this = default;
            Setup(dateRef);
        }

        public BalineseDate(int year, int month, int day)
        {
            this = default;
            var dateRef = new DateTime(year, month, day);
            Setup(dateRef);
        }

        private void Setup(DateTime dateRef)
        {
            date = new DateTime(dateRef.Year, dateRef.Month, dateRef.Day);
            var pivot = GetBestPivot(date);
            var pawukonDay = GetPawukonDay(pivot, date);

            wuku = Wuku.Values[Mathf.FloorToInt((float)pawukonDay / 7)];
            triWara = TriWara.Values[pawukonDay % 3];
            pancaWara = PancaWara.Values[pawukonDay % 5];
            sadWara = SadWara.Values[pawukonDay % 6];
            saptaWara = SaptaWara.Values[pawukonDay % 7];
            jejepan = Jejepan.Values[pawukonDay % 6];
            lintang = Lintang.Values[pawukonDay % 35];
            pancaSuda = PancaSuda.Values[(saptaWara.KertaAji + pancaWara.Urip) % 7];
            rakam = Rakam.Values[(saptaWara.Kupih + pancaWara.Kupih) % 6];
            ekaJalaRsi = EkaJalaRsi.Values[EJR_MAP[pawukonDay]];
            ingkel = Ingkel.Values[wuku.Id % 6];

            var urip = pancaWara.Urip + saptaWara.Urip;
            ekaWara = EkaWara.Values[urip % 2];
            dwiWara = DwiWara.Values[urip % 2];
            dasaWara = DasaWara.Values[urip % 10];
            watekAlit = WatekAlit.Values[urip % 4];
            watekMadya = WatekMadya.Values[urip % 5];
            pararasan = Pararasan.Values[urip % 10];
            caturWara = CalculateCaturWara(pawukonDay);
            astaWara = CalculateAstaWara(pawukonDay);
            sangaWara = CalculateSangaWara(pawukonDay);

            var resSasih = CalculateSasihInfo(pivot, dateRef);
            var resSasihDay = CalculateSasihDay(pivot, dateRef);
            saka = resSasih[0];
            sasih = CalculateSasih(resSasih);
            sasihDayInfo = CalculateSasihDayInfo(resSasihDay, sasih, saka);
            if (resSasihDay[2] == 1)
            {
                sasihDay = new int[] { resSasihDay[0], ((resSasihDay[0] == 15) ? 1 : resSasihDay[0] + 1) };
            }
            else
            {
                sasihDay = new int[] { resSasihDay[0] };
            }

            pratithiSamutPada = CalculatePratithiSamutPada(sasihDay, sasihDayInfo, sasih, dateRef);
            dewasa = GetDewasaByWuku(wuku);
        }

        private Pivot GetBestPivot(DateTime date) => date < PANGALANTAKA_PAING ? Pivot.PIVOT_1971 : Pivot.PIVOT_2000;

        private int GetPawukonDay(Pivot pivot, DateTime date) =>
            GetMod(pivot.PawukonDay + GetDeltaDays(pivot.Date, date), DAY_PAWUKON);

        private CaturWara CalculateCaturWara(int pawukonDay)
        {
            if (pawukonDay < 71)
            {
                return CaturWara.Values[pawukonDay % 4];
            }
            else if (pawukonDay > 72)
            {
                return CaturWara.Values[(pawukonDay - 2) % 4];
            }
            else
            {
                return CaturWara.JAYA;
            }
        }

        private AstaWara CalculateAstaWara(int pawukonDay)
        {
            if (pawukonDay < 71)
            {
                return AstaWara.Values[pawukonDay % 8];
            }
            else if (pawukonDay > 72)
            {
                return AstaWara.Values[(pawukonDay - 2) % 8];
            }
            else
            {
                return AstaWara.KALA;
            }
        }

        private SangaWara CalculateSangaWara(int pawukonDay)
        {
            if (pawukonDay > 3)
            {
                return SangaWara.Values[(pawukonDay - 3) % 9];
            }
            else
            {
                return SangaWara.DANGU;
            }
        }

        private int[] CalculateSasihInfo(Pivot pivot, DateTime date)
        {
            var res = new int[3];

            var ptime = pivot.Date;
            var dayDiff = GetDeltaDays(ptime, date);
            var daySkip = (int)Math.Ceiling(dayDiff / (double)DAY_NGUNARATRI);
            var dayTotal = pivot.SasihDay + dayDiff + daySkip;

            var pivotOffset = (pivot.SasihDay == 0 && pivot.NgunaRatriDay == 0) ? 0 : 1;

            var totalSasih = (int)Math.Ceiling(dayTotal / 30.0) - pivotOffset;

            var currentSasih = pivot.Sasih.Id;
            var currentSaka = pivot.Saka - (currentSasih == Sasih.KADASA.Id ? 1 : 0);
            var nampihCount = pivot.IsNampihSasih ? 1 : 0;

            var inSK = false;
            if (DateTime.Compare(ptime, SK_START) >= 0 && DateTime.Compare(ptime, SK_END) < 0)
            {
                inSK = true;
            }

            while (totalSasih != 0)
            {
                if (dayDiff >= 0)
                {
                    if (nampihCount == 0 || nampihCount == 2)
                    {
                        nampihCount = 0;
                        currentSasih = GetMod(currentSasih + 1, 12);
                    }

                    totalSasih = totalSasih - 1;

                    if (currentSasih == Sasih.KADASA.Id && nampihCount == 0)
                    {
                        currentSaka = currentSaka + 1;
                    }

                    if (currentSasih == Sasih.KAWOLU.Id && currentSaka == 1914)
                    {
                        inSK = true;
                    }
                    else if (currentSasih == Sasih.KAWOLU.Id && currentSaka == 1924)
                    {
                        inSK = false;
                    }
                }
                else // dayDiff < 0
                {
                    if (nampihCount == 0 || nampihCount == 2)
                    {
                        nampihCount = 0;
                        currentSasih = GetMod(currentSasih - 1, 12);
                    }

                    totalSasih = totalSasih + 1;

                    if (currentSasih == Sasih.KASANGA.Id && nampihCount == 0)
                    {
                        currentSaka = currentSaka - 1;
                    }

                    if (currentSasih == Sasih.KAPITU.Id && currentSaka == 1914)
                    {
                        inSK = false;
                    }
                    else if (currentSasih == Sasih.KAPITU.Id && currentSaka == 1924)
                    {
                        inSK = true;
                    }
                }

                switch (currentSaka % 19)
                {
                    case 0:
                    case 6:
                    case 11:
                        if (currentSasih == Sasih.DESTHA.Id && !inSK)
                        {
                            if (currentSaka != 1925)
                            {
                                nampihCount++;
                            }
                        }

                        break;
                    case 3:
                    case 8:
                    case 14:
                    case 16:
                        if (currentSasih == Sasih.SADHA.Id && !inSK)
                        {
                            nampihCount++;
                        }

                        break;
                    case 2:
                    case 10:
                        if (currentSasih == Sasih.DESTHA.Id && inSK)
                        {
                            nampihCount++;
                        }

                        break;
                    case 4:
                        if (currentSasih == Sasih.KATIGA.Id && inSK)
                        {
                            nampihCount++;
                        }

                        break;
                    case 7:
                        if (currentSasih == Sasih.KASA.Id && inSK)
                        {
                            nampihCount++;
                        }

                        break;
                    case 13:
                        if (currentSasih == Sasih.KADASA.Id && inSK)
                        {
                            nampihCount++;
                        }

                        break;
                    case 15:
                        if (currentSasih == Sasih.KARO.Id && inSK)
                        {
                            nampihCount++;
                        }

                        break;
                    case 18:
                        if (currentSasih == Sasih.SADHA.Id && inSK)
                        {
                            nampihCount++;
                        }

                        break;
                    default:
                        break;
                }
            }

            res[0] = currentSaka;
            res[1] = currentSasih;

            if (dayTotal >= 0)
            {
                res[2] = nampihCount == 2 ? 1 : 0;
            }
            else
            {
                res[2] = nampihCount == 1 ? 1 : 0;
            }

            return res;
        }

        private int[] CalculateSasihDay(Pivot pivot, DateTime date)
        {
            var res = new int[3];

            var ptime = pivot.Date;
            var dayDiff = GetDeltaDays(ptime, date);
            var daySkip = (int)Math.Ceiling(dayDiff / (double)DAY_NGUNARATRI);
            var dayTotal = pivot.SasihDay + dayDiff + daySkip;

            res[0] = GetMod(dayTotal, 30);
            res[1] = (res[0] == 0 || res[0] > 15) ? 1 : 0;
            res[2] = (GetMod(dayDiff, DAY_NGUNARATRI) == 0) ? 1 : 0;
            res[0] = GetMod(res[0], 15);
            res[0] = (res[0] == 0) ? 15 : res[0];

            return res;
        }

        private Sasih CalculateSasih(int[] resSasih)
        {
            var saka = resSasih[0];
            var sasihIdx = resSasih[1];
            var res = Sasih.Values[sasihIdx];

            if (resSasih[2] == 1)
            {
                if (res == Sasih.DESTHA)
                {
                    res = (saka < 1914) ? Sasih.MALA_DESTHA : Sasih.NAMPIH_DESTHA;
                }
                else if (res == Sasih.KATIGA)
                {
                    res = Sasih.NAMPIH_KATIGA;
                }
                else if (res == Sasih.KASA)
                {
                    res = Sasih.NAMPIH_KASA;
                }
                else if (res == Sasih.KADASA)
                {
                    res = Sasih.NAMPIH_KADASA;
                }
                else if (res == Sasih.KARO)
                {
                    res = Sasih.NAMPIH_KARO;
                }
                else if (res == Sasih.SADHA)
                {
                    res = (saka < 1914) ? Sasih.MALA_SADHA : Sasih.NAMPIH_SADHA;
                }
            }

            return res;
        }

        private SasihDayInfo CalculateSasihDayInfo(int[] resSasihDay, Sasih sasih, int saka)
        {
            var date = resSasihDay[0];
            var isPangelong = resSasihDay[1] == 1;
            var isNgunaRatri = resSasihDay[2] == 1;

            if (isPangelong)
            {
                if (date == 15 || (date == 14 && isNgunaRatri))
                {
                    return SasihDayInfo.TILEM;
                }
                else if (date == 14 && sasih == Sasih.KAPITU && saka == 1921)
                {
                    return SasihDayInfo.TILEM;
                }
                else
                {
                    return SasihDayInfo.PANGELONG;
                }
            }
            else
            {
                if (date == 15 || (date == 14 && isNgunaRatri))
                {
                    return SasihDayInfo.PURNAMA;
                }
                else
                {
                    return SasihDayInfo.PENANGGAL;
                }
            }
        }

        private PratithiSamutPada CalculatePratithiSamutPada(int[] sasihDay, SasihDayInfo sasihDayInfo, Sasih sasih,
            DateTime date)
        {
            var move = 0;
            var isNG = sasihDay.Length > 1;
            var day = isNG ? sasihDay[1] : sasihDay[0];

            if (sasihDayInfo.Reference == SasihDayInfo.PENANGGAL)
            {
                if (day == 1 && isNG)
                {
                    move = 0;
                }
                else
                {
                    if (day >= 1 && day <= 8)
                    {
                        move = day - 1;
                    }
                    else if (day >= 9 && day <= 13)
                    {
                        move = day - 2;
                    }
                    else if (day == 14)
                    {
                        move = 11;
                    }
                    else if (day == 15)
                    {
                        move = 0;
                    }
                }
            }
            else
            {
                if (day == 1 && isNG)
                {
                    var temp = date.AddDays(1);
                    var nextDay = new BalineseDate(temp);
                    if (nextDay.sasih.Reference != sasih.Reference)
                    {
                        move = -1;
                    }
                }
                else
                {
                    move = (day >= 13) ? day - 11 : day - 1;
                }
            }

            var start = PratithiSamutPada.Values[sasih.Reference.Id];
            var newID = GetMod(start.Id - move, 12);
            return PratithiSamutPada.Values[newID];
        }

        private List<Dewasa> GetDewasaByWuku(Wuku wuku)
        {
            var list = new List<Dewasa>();
            switch (wuku.Id)
            {
                case 0: ApplyDewasaBySinta(list); break;
                case 1: ApplyDewasaByLandep(list); break;
                case 2: ApplyDewasaByUkir(list); break;
                case 3: ApplyDewasaByKulantir(list); break;
                case 4: ApplyDewasaByTolu(list); break;
                case 5: ApplyDewasaByGumbreg(list); break;
                case 6: ApplyDewasaByWariga(list); break;
                case 7: ApplyDewasaByWarigadean(list); break;
                case 8: ApplyDewasaByJulungwangi(list); break;
                case 9: ApplyDewasaBySungsang(list); break;
                case 10: ApplyDewasaByDungulan(list); break;
                case 11: ApplyDewasaByKuningan(list); break;
                case 12: ApplyDewasaByLangkir(list); break;
                case 13: ApplyDewasaByMedangsia(list); break;
                case 14: ApplyDewasaByPujut(list); break;
                case 15: ApplyDewasaByPahang(list); break;
                case 16: ApplyDewasaByKrulut(list); break;
                case 17: ApplyDewasaByMerakih(list); break;
                case 18: ApplyDewasaByTambir(list); break;
                case 19: ApplyDewasaByMedangkungan(list); break;
                case 20: ApplyDewasaByMatal(list); break;
                case 21: ApplyDewasaByUye(list); break;
                case 22: ApplyDewasaByMenail(list); break;
                case 23: ApplyDewasaByPrangbakat(list); break;
                case 24: ApplyDewasaByBala(list); break;
                case 25: ApplyDewasaByUgu(list); break;
                case 26: ApplyDewasaByWayang(list); break;
                case 27: ApplyDewasaByKlawu(list); break;
                case 28: ApplyDewasaByDukut(list); break;
                case 29: ApplyDewasaByWatugunung(list); break;
            }
            return list;
        }

        private void ApplyDewasaBySinta(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_GEDE);
            list.Add(Dewasa.CARIK_WALANGATI);
            list.Add(Dewasa.SALAH_WADI);
        }

        private void ApplyDewasaByLandep(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_CENIK);
            list.Add(Dewasa.SALAH_WADI);
        }

        private void ApplyDewasaByUkir(List<Dewasa> list)
        {
            list.Add(Dewasa.LANUS);
        }

        private void ApplyDewasaByKulantir(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_CENIK);
            list.Add(Dewasa.BASAH_GEDE);
            list.Add(Dewasa.KALA_INGSOR);
        }

        private void ApplyDewasaByTolu(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_CENIK);
            list.Add(Dewasa.WAS_PENGANTEN);
        }

        private void ApplyDewasaByGumbreg(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_CENIK);
            list.Add(Dewasa.CARIK_WALANGATI);
            list.Add(Dewasa.SALAH_WADI);
            list.Add(Dewasa.TANPA_GURU);
        }

        private void ApplyDewasaByWariga(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_CENIK);
            list.Add(Dewasa.CARIK_WALANGATI);
            list.Add(Dewasa.KALA_SARANG);
            list.Add(Dewasa.RANGDA_TIGA);
        }

        private void ApplyDewasaByWarigadean(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_CENIK);
            list.Add(Dewasa.RANGDA_TIGA);
        }

        private void ApplyDewasaByJulungwangi(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_GEDE);
        }

        private void ApplyDewasaBySungsang(List<Dewasa> list)
        {
            list.Add(Dewasa.CARIK_WALANGATI);
            list.Add(Dewasa.LANUS);
            list.Add(Dewasa.SALAH_WADI);
        }

        private void ApplyDewasaByDungulan(List<Dewasa> list)
        {
            list.Add(Dewasa.LANUS);
            list.Add(Dewasa.SALAH_WADI);
            list.Add(Dewasa.WAS_PENGANTEN);
        }

        private void ApplyDewasaByKuningan(List<Dewasa> list)
        {
            list.Add(Dewasa.CARIK_WALANGATI);
            list.Add(Dewasa.LANUS);
            list.Add(Dewasa.TANPA_GURU);
        }

        private void ApplyDewasaByLangkir(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_CENIK);
        }

        private void ApplyDewasaByMedangsia(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_CENIK);
            list.Add(Dewasa.KALA_INGSOR);
        }

        private void ApplyDewasaByPujut(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_CENIK);
            list.Add(Dewasa.RANGDA_TIGA);
        }

        private void ApplyDewasaByPahang(List<Dewasa> list)
        {
            list.Add(Dewasa.LANUS);
            list.Add(Dewasa.RANGDA_TIGA);
            list.Add(Dewasa.SALAH_WADI);
        }

        private void ApplyDewasaByKrulut(List<Dewasa> list)
        {
            list.Add(Dewasa.KALA_SARANG);
            list.Add(Dewasa.LANUS);
            list.Add(Dewasa.WAS_PENGANTEN);
        }

        private void ApplyDewasaByMerakih(List<Dewasa> list)
        {
            list.Add(Dewasa.LANUS);
        }

        private void ApplyDewasaByTambir(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_CENIK);
            list.Add(Dewasa.SALAH_WADI);
        }

        private void ApplyDewasaByMedangkungan(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_GEDE);
            list.Add(Dewasa.SALAH_WADI);
            list.Add(Dewasa.TANPA_GURU);
        }

        private void ApplyDewasaByMatal(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_GEDE);
        }

        private void ApplyDewasaByUye(List<Dewasa> list)
        {
            list.Add(Dewasa.LANUS);
        }

        private void ApplyDewasaByMenail(List<Dewasa> list)
        {
            list.Add(Dewasa.LANUS);
            list.Add(Dewasa.RANGDA_TIGA);
            list.Add(Dewasa.WAS_PENGANTEN);
        }

        private void ApplyDewasaByPrangbakat(List<Dewasa> list)
        {
            list.Add(Dewasa.CARIK_WALANGATI);
            list.Add(Dewasa.KALA_INGSOR);
            list.Add(Dewasa.LANUS);
            list.Add(Dewasa.RANGDA_TIGA);
            list.Add(Dewasa.SALAH_WADI);
        }

        private void ApplyDewasaByBala(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_CENIK);
            list.Add(Dewasa.CARIK_WALANGATI);
            list.Add(Dewasa.SALAH_WADI);
        }

        private void ApplyDewasaByUgu(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_GEDE);
        }

        private void ApplyDewasaByWayang(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_GEDE);
            list.Add(Dewasa.CARIK_WALANGATI);
            list.Add(Dewasa.KALA_SUNGSANG);
            list.Add(Dewasa.SALAH_WADI);
        }

        private void ApplyDewasaByKlawu(List<Dewasa> list)
        {
            list.Add(Dewasa.CARIK_WALANGATI);
            list.Add(Dewasa.LANUS);
            list.Add(Dewasa.TANPA_GURU);
        }

        private void ApplyDewasaByDukut(List<Dewasa> list)
        {
            list.Add(Dewasa.LANUS);
            list.Add(Dewasa.WAS_PENGANTEN);
        }

        private void ApplyDewasaByWatugunung(List<Dewasa> list)
        {
            list.Add(Dewasa.BASAH_GEDE);
            list.Add(Dewasa.CARIK_WALANGATI);
            list.Add(Dewasa.SALAH_WADI);
        }

        private int GetMod(int a, int b) => ((a % b) + b) % b;
        private int GetDeltaDays(DateTime from, DateTime to) => (to - from.Date).Days;
        public bool Equals(BalineseDate other) => date == other.date;
        public static bool operator ==(BalineseDate left, BalineseDate right) => left.date == right.date;
        public static bool operator !=(BalineseDate left, BalineseDate right) => left.date != right.date;
        public override bool Equals(object obj) => obj is BalineseDate other && Equals(other);
        public override int GetHashCode() => date.GetHashCode();
    }
}