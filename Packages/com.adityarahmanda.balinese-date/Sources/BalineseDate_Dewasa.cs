using System.Collections.Generic;

namespace BalineseCalendar
{
    public partial struct BalineseDate
    {
        private List<Dewasa> GetDewasaBySaptaWaraWuku(SaptaWara saptaWara, Wuku wuku)
        {
            var list = new List<Dewasa>();
            if (wuku == Wuku.SINTA)
            {
                list.Add(Dewasa.BASAH_GEDE);
                list.Add(Dewasa.CARIK_WALANGATI);
                list.Add(Dewasa.SALAH_WADI);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_BANCARAN);
                    list.Add(Dewasa.KALA_MRETYU);
                    list.Add(Dewasa.KALA_PRAWANI);
                    list.Add(Dewasa.KALA_RAU);
                    list.Add(Dewasa.KALA_TEMAH);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_SIYUNG);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.SAMPAR_WANGKE);
                    list.Add(Dewasa.TALI_WANGKE);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_EMPAS);
                    list.Add(Dewasa.KALA_LUANG);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.BANU_MILIR);
                    list.Add(Dewasa.KALA_BRAHMA);
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_MRETYU);
                    list.Add(Dewasa.KALA_SIYUNG);
                    list.Add(Dewasa.KALA_SUDUKAN);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.ASUAJAG_MUNGGAH);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KALA_BESER);
                    list.Add(Dewasa.KALA_MINA);
                }
            }
            else if (wuku == Wuku.LANDEP)
            {
                list.Add(Dewasa.BASAH_CENIK);
                list.Add(Dewasa.SALAH_WADI);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KALA_SIYUNG);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_GRAHA);
                    list.Add(Dewasa.KALA_KUTILA_MANIK);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_SUDUKAN);
                    list.Add(Dewasa.KALA_SUWUNG);
                    list.Add(Dewasa.KALA_TEMAH);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.KALA_GARUDA);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.GUNTUR_GRAHA);
                    list.Add(Dewasa.KALA_GURU);
                    list.Add(Dewasa.KALA_LUANG);
                    list.Add(Dewasa.KALA_PRAWANI);
                    list.Add(Dewasa.KALA_SUDANGASTRA);
                    list.Add(Dewasa.KALA_WISESA);
                    list.Add(Dewasa.TALI_WANGKE);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.JIWA_MANGANTI);
                    list.Add(Dewasa.KALA_MERENG);
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.BABI_MUNGGAH);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.BOJOG_TURUN);
                    list.Add(Dewasa.KALA_KUTILA);
                }
            }
            else if (wuku == Wuku.UKIR)
            {
                list.Add(Dewasa.LANUS);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.ASUASA);
                    list.Add(Dewasa.KALA_JENGKING);
                    list.Add(Dewasa.KALA_NGUNA);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.SRIGATI_MUNGGAH);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_SAPUHAU);
                    list.Add(Dewasa.KALA_SUDUKAN);
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_TEMAH);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.KALA_EMPAS);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.LUTUNG_MAGANDONG);
                    list.Add(Dewasa.TUTUR_MANDI);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.ASUAJAG_TURUN);
                    list.Add(Dewasa.KAJENG_RENDETAN);
                    list.Add(Dewasa.KALA_DEMIT);
                    list.Add(Dewasa.KALA_PEGAT);
                    list.Add(Dewasa.KALA_RAU);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_TEMAH);
                }
            }
            else if (wuku == Wuku.KULANTIR)
            {
                list.Add(Dewasa.BASAH_CENIK);
                list.Add(Dewasa.BASAH_GEDE);
                list.Add(Dewasa.KALA_INGSOR);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.BANU_MILIR);
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_MUAS);
                    list.Add(Dewasa.SAMPI_GUMARANG_MUNGGAH);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.KALA_BANGKUNG);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.KALA_KUTILA_MANIK);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.SRIGATI_JENEK);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.SARIK_AGUNG);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {

                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.KALA_BRAHMA);
                    list.Add(Dewasa.KALA_GUMARANG);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.BABI_TURUN);
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_RAU);
                }
            }
            else if (wuku == Wuku.TOLU)
            {
                list.Add(Dewasa.BASAH_CENIK);
                list.Add(Dewasa.KALA_PATI);
                list.Add(Dewasa.WAS_PENGANTEN);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.BOJOG_MUNGGAH);
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_MATAMPAK);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.SRIGATI_TURUN);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_BANCARAN);
                    list.Add(Dewasa.KALA_BESER);
                    list.Add(Dewasa.KALA_MINA);
                    list.Add(Dewasa.KALA_PACEKAN);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.GUNTUR_GRAHA);
                    list.Add(Dewasa.KALA_LUANG);
                    list.Add(Dewasa.KALA_SUWUNG);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_EMPAS);
                    list.Add(Dewasa.KALA_MRETYU);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_TEMAH);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.KALA_SUDUKAN);
                    list.Add(Dewasa.KALA_TEMAH);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KALA_GRAHA);
                    list.Add(Dewasa.KALA_WISESA);
                }
            }
            else if (wuku == Wuku.GUMBREG)
            {
                list.Add(Dewasa.BASAH_CENIK);
                list.Add(Dewasa.CARIK_WALANGATI);
                list.Add(Dewasa.SALAH_WADI);
                list.Add(Dewasa.TANPA_GURU);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.ASUAJAG_MUNGGAH);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.SAMPI_GUMARANG_TURUN);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_KUTILA);
                    list.Add(Dewasa.KALA_PATI);
                    list.Add(Dewasa.KALA_SUDUKAN);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.KAJENG_RENDETAN);
                    list.Add(Dewasa.KALA_JENGKING);
                    list.Add(Dewasa.KALA_KUTILA_MANIK);
                    list.Add(Dewasa.KALA_LUANG);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_SUWUNG);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_RAU);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KALA_SUDANGASTRA);
                }
            }
            else if (wuku == Wuku.WARIGA)
            {
                list.Add(Dewasa.BASAH_CENIK);
                list.Add(Dewasa.CARIK_WALANGATI);
                list.Add(Dewasa.KALA_SARANG);
                list.Add(Dewasa.RANGDA_TIGA);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.BABI_MUNGGAH);
                    list.Add(Dewasa.KALA_PANENENG);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.SAMPAR_WANGKE);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.ASUASA);
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.SRIGATI_MUNGGAH);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.KALA_BUINGRAU);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_PAGER);
                    list.Add(Dewasa.TALI_WANGKE);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.JIWA_MANGANTI);
                    list.Add(Dewasa.KALA_EMPAS);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KALA_BANCARAN);
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_MATAMPAK);
                }
            }
            else if (wuku == Wuku.WARIGADEAN)
            {
                list.Add(Dewasa.BASAH_CENIK);
                list.Add(Dewasa.RANGDA_TIGA);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.BOJOG_MUNGGAH);
                    list.Add(Dewasa.KALA_BUINGRAU);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.ASUAJAG_TURUN);
                    list.Add(Dewasa.BANU_MILIR);
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.BOJOG_TURUN);
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_TEMAH);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.KALA_LUANG);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_SUDUKAN);
                    list.Add(Dewasa.KALA_SUWUNG);
                    list.Add(Dewasa.SAMPI_GUMARANG_MUNGGAH);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.KALA_KUTILA_MANIK);
                    list.Add(Dewasa.LUTUNG_MAGANDONG);
                    list.Add(Dewasa.SRIGATI_JENEK);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_MINA);
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_DANGU);
                }
            }
            else if (wuku == Wuku.JULUNGWANGI)
            {
                list.Add(Dewasa.BASAH_GEDE);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KAJENG_RENDETAN);
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_MERENG);
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.BABI_TURUN);
                    list.Add(Dewasa.KALA_CAPLOKAN);
                    list.Add(Dewasa.KALA_RUMPUH);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.BOJOG_MUNGGAH);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_WISESA);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.SRIGATI_TURUN);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.TUTUR_MANDI);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.KALA_KUTILA);
                    list.Add(Dewasa.KALA_MRETYU);
                    list.Add(Dewasa.KALA_TEMAH);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_CAPLOKAN);
                    list.Add(Dewasa.KALA_EMPAS);
                    list.Add(Dewasa.KALA_JENGKING);
                    list.Add(Dewasa.KALA_SOR);
                }
            }
            else if (wuku == Wuku.SUNGSANG)
            {
                list.Add(Dewasa.CARIK_WALANGATI);
                list.Add(Dewasa.LANUS);
                list.Add(Dewasa.SALAH_WADI);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KALA_PATI);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_NGERUDA);
                    list.Add(Dewasa.KALA_SIYUNG);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.ASUAJAG_MUNGGAH);
                    list.Add(Dewasa.KALA_LUANG);
                    list.Add(Dewasa.KALA_SUWUNG);
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_PATI);
                    list.Add(Dewasa.KALA_RUMPUH);
                    list.Add(Dewasa.SAMPI_GUMARANG_TURUN);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.KALA_TEMAH);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_KUTILA_MANIK);
                    list.Add(Dewasa.KALA_NGERUDA);
                }
            }
            else if (wuku == Wuku.DUNGULAN)
            {
                list.Add(Dewasa.KALA_PATI);
                list.Add(Dewasa.LANUS);
                list.Add(Dewasa.SALAH_WADI);
                list.Add(Dewasa.WAS_PENGANTEN);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KALA_LUANG);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.KALA_ISINAN);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_MERENG);
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.BABI_MUNGGAH);
                    list.Add(Dewasa.KALA_BANCARAN);
                    list.Add(Dewasa.KALA_BESER);
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_MINA);
                    list.Add(Dewasa.KALA_NGADEG);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.BOJOG_TURUN);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.SARIK_AGUNG);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.ASUASA);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.SRIGATI_MUNGGAH);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_RUMPUH);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_SUWUNG);
                    list.Add(Dewasa.KALA_WISESA);
                }
            }
            else if (wuku == Wuku.KUNINGAN)
            {
                list.Add(Dewasa.CARIK_WALANGATI);
                list.Add(Dewasa.LANUS);
                list.Add(Dewasa.TANPA_GURU);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KALA_EMPAS);
                    list.Add(Dewasa.KALA_LUANG);
                    list.Add(Dewasa.KALA_SUDUKAN);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.KALA_KUTILA);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.KALA_TUMAPEL);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.ASUAJAG_TURUN);
                    list.Add(Dewasa.KALA_JENGKING);
                    list.Add(Dewasa.KALA_NGADEG);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_SUDANGASTRA);
                    list.Add(Dewasa.KALA_TUMAPEL);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.SAMPI_GUMARANG_MUNGGAH);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.KALA_BANCARAN);
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_CAPLOKAN);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_NGADEG);
                    list.Add(Dewasa.KALA_RUMPUH);
                    list.Add(Dewasa.TALI_WANGKE);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KAJENG_RENDETAN);
                    list.Add(Dewasa.KALA_KUTILA_MANIK);
                    list.Add(Dewasa.SRIGATI_JENEK);
                }
            }
            else if (wuku == Wuku.LANGKIR)
            {
                list.Add(Dewasa.BASAH_CENIK);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_MATAMPAK);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.SAMPAR_WANGKE);
                    list.Add(Dewasa.TALI_WANGKE);
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_MERENG);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.BABI_TURUN);
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.BOJOG_MUNGGAH);
                    list.Add(Dewasa.COROK_KODONG);
                    list.Add(Dewasa.KALA_RUMPUH);
                    list.Add(Dewasa.LUTUNG_MAGANDONG);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.BANU_MILIR);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.SRIGATI_TURUN);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KALA_BRAHMA);
                    list.Add(Dewasa.KALA_SUWUNG);
                }
            }
            else if (wuku == Wuku.MEDANGSIA)
            {
                list.Add(Dewasa.BASAH_CENIK);
                list.Add(Dewasa.KALA_INGSOR);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_TEMAH);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.ASUASA);
                    list.Add(Dewasa.KAJENG_SUSUNAN);
                    list.Add(Dewasa.KALA_EMPAS);
                    list.Add(Dewasa.KALA_RUMPUH);
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_BRAHMA);
                    list.Add(Dewasa.KALA_PATI);
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.KALA_BANGKUNG);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.ASUAJAG_MUNGGAH);
                    list.Add(Dewasa.GUNTUR_GRAHA);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_RUMPUH);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.SAMPI_GUMARANG_TURUN);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_MRETYU);
                    list.Add(Dewasa.KALA_SUDUKAN);
                    list.Add(Dewasa.KALA_SUWUNG);
                    list.Add(Dewasa.KALA_TEMAH);
                }
            }
            else if (wuku == Wuku.PUJUT)
            {
                list.Add(Dewasa.BASAH_CENIK);
                list.Add(Dewasa.RANGDA_TIGA);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.ASUASA);
                    list.Add(Dewasa.KALA_KUTILA_MANIK);
                    list.Add(Dewasa.KALA_NGADEG);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_TEMAH);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {

                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.KALA_WISESA);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.KAJENG_RENDETAN);
                    list.Add(Dewasa.KALA_GUMARANG);
                    list.Add(Dewasa.KALA_MERENG);
                    list.Add(Dewasa.TITI_BUWUK);
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.BABI_MUNGGAH);
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.TUTUR_MANDI);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.BOJOG_TURUN);
                    list.Add(Dewasa.KALA_KUTILA);
                    list.Add(Dewasa.KALA_MRETYU);
                    list.Add(Dewasa.KALA_TEMAH);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KALA_CAPLOKAN);
                    list.Add(Dewasa.KALA_JENGKING);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_SIYUNG);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_SUDUKAN);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.SRIGATI_MUNGGAH);
                }
            }
            else if (wuku == Wuku.PAHANG)
            {
                list.Add(Dewasa.LANUS);
                list.Add(Dewasa.RANGDA_TIGA);
                list.Add(Dewasa.SALAH_WADI);
                if (saptaWara == SaptaWara.REDITE)
                {

                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_TEMAH);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_EMPAS);
                    list.Add(Dewasa.KALA_MATAMPAK);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.KALA_LUANG);
                    list.Add(Dewasa.KALA_SUWUNG);
                    list.Add(Dewasa.SAMPI_GUMARANG_MUNGGAH);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {

                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.ASUAJAG_TURUN);
                    list.Add(Dewasa.KAJENG_LULUNAN);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_MUAS);
                    list.Add(Dewasa.KALA_SUDUKAN);
                    list.Add(Dewasa.TITI_BUWUK);
                }
            }
            else if (wuku == Wuku.KRULUT)
            {
                list.Add(Dewasa.KALA_SARANG);
                list.Add(Dewasa.LANUS);
                list.Add(Dewasa.WAS_PENGANTEN);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KALA_ANGIN);
                    list.Add(Dewasa.KALA_NGADEG);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_ISINAN);
                    list.Add(Dewasa.KALA_KILANGKILUNG);
                    list.Add(Dewasa.KALA_KUTILA_MANIK);
                    list.Add(Dewasa.KALA_WAS);
                    list.Add(Dewasa.SRIGATI_JENEK);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_NGARABIN);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_MERENG);
                    list.Add(Dewasa.KALA_RUMPUH);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.BABI_TURUN);
                    list.Add(Dewasa.BANU_URUNG);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.BOJOG_MUNGGAH);
                    list.Add(Dewasa.KALA_PATI);
                    list.Add(Dewasa.KALA_SIYUNG);
                    list.Add(Dewasa.KALA_SUDUKAN);
                    list.Add(Dewasa.TALI_WANGKE);
                }
            }
            else if (wuku == Wuku.MERAKIH)
            {
                list.Add(Dewasa.LANUS);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KAJENG_RENDETAN);
                    list.Add(Dewasa.KALA_MRETYU);
                    list.Add(Dewasa.KALA_RUMPUH);
                    list.Add(Dewasa.SRIGATI_TURUN);
                    list.Add(Dewasa.TITI_BUWUK);
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_BESER);
                    list.Add(Dewasa.KALA_CAPLOKAN);
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_MINA);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.KALA_EMPAS);
                    list.Add(Dewasa.KALA_KUTILA_MANIK);
                    list.Add(Dewasa.KALA_LUANG);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_SUWUNG);
                    list.Add(Dewasa.SARIK_AGUNG);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.GUNTUR_GRAHA);
                    list.Add(Dewasa.LUTUNG_MAGANDONG);
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_WISESA);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.ASUAJAG_MUNGGAH);
                    list.Add(Dewasa.KALA_NGARABIN);
                    list.Add(Dewasa.KALA_PEGAT);
                    list.Add(Dewasa.KALA_RAU);
                }
            }
            else if (wuku == Wuku.TAMBIR)
            {
                list.Add(Dewasa.BASAH_CENIK);
                list.Add(Dewasa.SALAH_WADI);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.SAMPI_GUMARANG_TURUN);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.JIWA_MANGANTI);
                    list.Add(Dewasa.KALA_KUTILA);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_NGADEG);
                    list.Add(Dewasa.SAMPAR_WANGKE);
                    list.Add(Dewasa.TALI_WANGKE);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.KALA_GACOKAN);
                    list.Add(Dewasa.KALA_JENGKING);
                    list.Add(Dewasa.KALA_KUTILA_MANIK);
                    list.Add(Dewasa.KALA_LUANG);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_RUMPUH);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_KILANGKILUNG);
                    list.Add(Dewasa.KALA_MACAN);
                    list.Add(Dewasa.KALA_MERENG);
                    list.Add(Dewasa.KALA_PRAWANI);
                    list.Add(Dewasa.KALA_SUDANGASTRA);
                    list.Add(Dewasa.KALA_TEMAH);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.KALA_GUMARANG);
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.BABI_MUNGGAH);
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_BANGKUNG);
                }
            }
            else if (wuku == Wuku.MEDANGKUNGAN)
            {
                list.Add(Dewasa.BASAH_GEDE);
                list.Add(Dewasa.SALAH_WADI);
                list.Add(Dewasa.TANPA_GURU);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.BOJOG_TURUN);
                    list.Add(Dewasa.KALA_MRETYU);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.SRIGATI_MUNGGAH);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {

                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.KALA_SIYUNG);
                    list.Add(Dewasa.KALA_SUDUKAN);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.JIWA_MANGANTI);
                    list.Add(Dewasa.KALA_EMPAS);
                    list.Add(Dewasa.TUTUR_MANDI);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_TEMAH);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.GUNTUR_GRAHA);
                    list.Add(Dewasa.KALA_DANGU);
                }
            }
            else if (wuku == Wuku.MATAL)
            {
                list.Add(Dewasa.BASAH_GEDE);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.ASUAJAG_TURUN);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_SIYUNG);
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.SAMPI_GUMARANG_MUNGGAH);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.SRIGATI_JENEK);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.KALA_BESER);
                    list.Add(Dewasa.KALA_MINA);
                    list.Add(Dewasa.KALA_SUDUKAN);
                    list.Add(Dewasa.TUTUR_MANDI);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.KALA_DANGU);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KAJENG_RENDETAN);
                    list.Add(Dewasa.KALA_MERENG);
                    list.Add(Dewasa.KALA_RUMPUH);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.TITI_BUWUK);
                    list.Add(Dewasa.TUTUT_MASIH);
                }
            }
            else if (wuku == Wuku.UYE)
            {
                list.Add(Dewasa.LANUS);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.BABI_TURUN);
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_DANGU);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.BOJOG_MUNGGAH);
                    list.Add(Dewasa.KALA_SUDUKAN);
                    list.Add(Dewasa.KALA_WISESA);
                    list.Add(Dewasa.TALI_WANGKE);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.SRIGATI_TURUN);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {

                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_KUTILA);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_RUMPUH);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_EMPAS);
                    list.Add(Dewasa.KALA_JENGKING);
                    list.Add(Dewasa.KALA_KUTILA);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {

                }
            }
            else if (wuku == Wuku.MENAIL)
            {
                list.Add(Dewasa.KALA_PATI);
                list.Add(Dewasa.LANUS);
                list.Add(Dewasa.RANGDA_TIGA);
                list.Add(Dewasa.WAS_PENGANTEN);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KALA_BRAHMA);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.ASUAJAG_MUNGGAH);
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_MRETYU);
                    list.Add(Dewasa.KALA_NGERUDA);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_LUANG);
                    list.Add(Dewasa.KALA_SUWUNG);
                    list.Add(Dewasa.SAMPI_GUMARANG_TURUN);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.KALA_KUTILA_MANIK);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.LUTUNG_MAGANDONG);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_TEMAH);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KALA_CAKRA);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_RUMPUH);
                    list.Add(Dewasa.TITI_BUWUK);
                }
            }
            else if (wuku == Wuku.PRANGBAKAT)
            {
                list.Add(Dewasa.CARIK_WALANGATI);
                list.Add(Dewasa.KALA_INGSOR);
                list.Add(Dewasa.LANUS);
                list.Add(Dewasa.RANGDA_TIGA);
                list.Add(Dewasa.SALAH_WADI);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_GUMARANG);
                    list.Add(Dewasa.KALA_MERENG);
                    list.Add(Dewasa.KALA_SUDANGASTRA);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.BOJOG_MUNGGAH);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.BOJOG_TURUN);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_PRAWANI);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.ASUASA);
                    list.Add(Dewasa.KAJENG_RENDETAN);
                    list.Add(Dewasa.KALA_CAPLOKAN);
                    list.Add(Dewasa.KALA_OLIH);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.SRIGATI_MUNGGAH);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_RUMPUH);
                    list.Add(Dewasa.KALA_SIYUNG);
                    list.Add(Dewasa.TITI_BUWUK);
                    list.Add(Dewasa.TUTUR_MANDI);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.KALA_SUDUKAN);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_EMPAS);
                    list.Add(Dewasa.KALA_MATAMPAK);
                }
            }
            else if (wuku == Wuku.BALA)
            {
                list.Add(Dewasa.BASAH_CENIK);
                list.Add(Dewasa.CARIK_WALANGATI);
                list.Add(Dewasa.SALAH_WADI);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KALA_ANGIN);
                    list.Add(Dewasa.KALA_BESER);
                    list.Add(Dewasa.KALA_JENGKING);
                    list.Add(Dewasa.KALA_MINA);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_SIYUNG);
                    list.Add(Dewasa.KALA_SUDUKAN);
                    list.Add(Dewasa.SAMPAR_WANGKE);
                    list.Add(Dewasa.TALI_WANGKE);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.ASUAJAG_TURUN);
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_RUMPUH);
                    list.Add(Dewasa.SARIK_AGUNG);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_WISESA);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.JIWA_MANGANTI);
                    list.Add(Dewasa.KALA_BRAHMA);
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_KUTILA_MANIK);
                    list.Add(Dewasa.SRIGATI_JENEK);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KALA_DANGU);
                }
            }
            else if (wuku == Wuku.UGU)
            {
                list.Add(Dewasa.BASAH_GEDE);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KALA_KUTILA);
                    list.Add(Dewasa.TITI_BUWUK);
                    list.Add(Dewasa.TUTUR_MANDI);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.KALA_JENGKING);
                    list.Add(Dewasa.KALA_MERENG);
                    list.Add(Dewasa.KALA_REBUTAN);
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.BABI_TURUN);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.BOJOG_MUNGGAH);
                    list.Add(Dewasa.KALA_PATI);
                    list.Add(Dewasa.KALA_RUMPUH);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.KALA_SIYUNG);
                    list.Add(Dewasa.SRIGATI_TURUN);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_SUDUKAN);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.GUNTUR_GRAHA);
                    list.Add(Dewasa.KALA_BUINGRAU);
                }
            }
            else if (wuku == Wuku.WAYANG)
            {
                list.Add(Dewasa.BASAH_GEDE);
                list.Add(Dewasa.CARIK_WALANGATI);
                list.Add(Dewasa.KALA_SUNGSANG);
                list.Add(Dewasa.SALAH_WADI);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KAJENG_RENDETAN);
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_EMPAS);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.KALA_LUANG);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_MUAS);
                    list.Add(Dewasa.KALA_SUWUNG);
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.KALA_MRETYU);
                    list.Add(Dewasa.KALA_PATI);
                    list.Add(Dewasa.KALA_SAPUHAU);
                    list.Add(Dewasa.KALA_SUDUKAN);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.TALI_WANGKE);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.ASUAJAG_MUNGGAH);
                    list.Add(Dewasa.KALA_RUMPUH);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.SAMPI_GUMARANG_TURUN);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.TUTUT_MASIH);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KALA_KUTILA_MANIK);
                    list.Add(Dewasa.KALA_SOR);
                }
            }
            else if (wuku == Wuku.KLAWU)
            {
                list.Add(Dewasa.CARIK_WALANGATI);
                list.Add(Dewasa.KALA_PATI);
                list.Add(Dewasa.LANUS);
                list.Add(Dewasa.TANPA_GURU);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KALA_ANGIN);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_NGADEG);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.KALA_SUDANGASTRA);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.BABI_MUNGGAH);
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_BESER);
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_MINA);
                    list.Add(Dewasa.KALA_SAPUHAU);
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.BOJOG_TURUN);
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_LUANG);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.LUTUNG_MAGANDONG);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.ASUASA);
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_BESER);
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_SIYUNG);
                    list.Add(Dewasa.KALA_SOR);
                    list.Add(Dewasa.KALA_SUWUNG);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.SRIGATI_MUNGGAH);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KALA_RUMPUH);
                    list.Add(Dewasa.KALA_TEMAH);
                }
            }
            else if (wuku == Wuku.DUKUT)
            {
                list.Add(Dewasa.KALA_PATI);
                list.Add(Dewasa.LANUS);
                list.Add(Dewasa.WAS_PENGANTEN);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_MATAMPAK);
                    list.Add(Dewasa.KALA_NGERUDA);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.KALA_WISESA);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.KALA_EMPAS);
                    list.Add(Dewasa.KALA_SIYUNG);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_KUTILA);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.ASUAJAG_TURUN);
                    list.Add(Dewasa.KALA_JENGKING);
                    list.Add(Dewasa.KALA_LUANG);
                    list.Add(Dewasa.KALA_RAJA);
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.BANU_URUNG);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.SAMPI_GUMARANG_MUNGGAH);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.KALA_BANGKUNG);
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.KALA_RUMPUH);
                    list.Add(Dewasa.KALA_TEMAH);
                    list.Add(Dewasa.TITI_BUWUK);
                }
            }
            else if (wuku == Wuku.WATUGUNUNG)
            {
                list.Add(Dewasa.BASAH_GEDE);
                list.Add(Dewasa.CARIK_WALANGATI);
                list.Add(Dewasa.SALAH_WADI);
                if (saptaWara == SaptaWara.REDITE)
                {
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_KUTILA_MANIK);
                    list.Add(Dewasa.KALA_RUMPUH);
                    list.Add(Dewasa.SRIGATI_JENEK);
                    list.Add(Dewasa.TITI_BUWUK);
                }
                else if (saptaWara == SaptaWara.SOMA)
                {
                    list.Add(Dewasa.KALA_TEMAH);
                }
                else if (saptaWara == SaptaWara.ANGGARA)
                {
                    list.Add(Dewasa.KALA_LUANG);
                }
                else if (saptaWara == SaptaWara.BUDA)
                {
                    list.Add(Dewasa.KALA_GUMARANG);
                    list.Add(Dewasa.KALA_ISINAN);
                    list.Add(Dewasa.KALA_MERENG);
                    list.Add(Dewasa.KALA_SOR);
                }
                else if (saptaWara == SaptaWara.WRASPATI)
                {
                    list.Add(Dewasa.BABI_TURUN);
                    list.Add(Dewasa.BOJOG_MUNGGAH);
                    list.Add(Dewasa.KALA_MATAMPAK);
                }
                else if (saptaWara == SaptaWara.SUKRA)
                {
                    list.Add(Dewasa.BOJOG_MUNGGAH);
                    list.Add(Dewasa.KALA_BESER);
                    list.Add(Dewasa.KALA_BRAHMA);
                    list.Add(Dewasa.KALA_BUINGRAU);
                    list.Add(Dewasa.KALA_NGADEG);
                    list.Add(Dewasa.KALA_PANENENG);
                    list.Add(Dewasa.KALA_SAPUHAU);
                    list.Add(Dewasa.KALA_SUWUNG);
                    list.Add(Dewasa.KALA_TEMAH);
                }
                else if (saptaWara == SaptaWara.SANISCARA)
                {
                    list.Add(Dewasa.JIWA_MANGANTI);
                    list.Add(Dewasa.KAJENG_RENDETAN);
                    list.Add(Dewasa.KALA_DANGU);
                    list.Add(Dewasa.SRIGATI_TURUN);
                }
            }
            return list;
        }
    }
}