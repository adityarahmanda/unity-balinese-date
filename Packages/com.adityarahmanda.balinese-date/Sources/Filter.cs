using System;

namespace BalineseCalendar
{
    [Serializable]
    public class Filter
    {
        public EkaWara ekaWara
        {
            get
            {
                return ekaWaraId >= 0 && ekaWaraId < EkaWara.Values.Length ? EkaWara.Values[ekaWaraId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    ekaWaraId = -1;
                    return;
                }
                
                ekaWaraId = value.Id;
            }
        }

        public DwiWara dwiWara
        {
            get
            {
                return dwikaraId >= 0 && dwikaraId < DwiWara.Values.Length ? DwiWara.Values[dwikaraId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    dwikaraId = -1;
                    return;
                }
                
                dwikaraId = value.Id;
            }
        }
        
        public TriWara triWara
        {
            get
            {
                return triWaraId >= 0 && triWaraId < TriWara.Values.Length ? TriWara.Values[triWaraId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    triWaraId = -1;
                    return;
                }
                
                triWaraId = value.Id;
            }
        }
        
        public CaturWara caturWara
        {
            get
            {
                return caturWaraId >= 0 && caturWaraId < CaturWara.Values.Length ? CaturWara.Values[caturWaraId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    caturWaraId = -1;
                    return;
                }
                
                caturWaraId = value.Id;
            }
        }
        
        public PancaWara pancaWara
        {
            get
            {
                return pancaWaraId >= 0 && pancaWaraId < PancaWara.Values.Length ? PancaWara.Values[pancaWaraId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    pancaWaraId = -1;
                    return;
                }
                
                pancaWaraId = value.Id;
            }
        }
        
        public SadWara sadWara
        {
            get
            {
                return sadWaraId >= 0 && sadWaraId < SadWara.Values.Length ? SadWara.Values[sadWaraId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    sadWaraId = -1;
                    return;
                }
                
                sadWaraId = value.Id;
            }
        }
        
        public SaptaWara saptaWara
        {
            get
            {
                return saptaWaraId >= 0 && saptaWaraId < SaptaWara.Values.Length ? SaptaWara.Values[saptaWaraId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    saptaWaraId = -1;
                    return;
                }
                
                saptaWaraId = value.Id;
            }
        }
        
        public AstaWara astaWara
        {
            get
            {
                return astaWaraId >= 0 && astaWaraId < AstaWara.Values.Length ? AstaWara.Values[astaWaraId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    astaWaraId = -1;
                    return;
                }
                
                astaWaraId = value.Id;
            }
        }
        
        public SangaWara sangaWara
        {
            get
            {
                return sangaWaraId >= 0 && sangaWaraId < SangaWara.Values.Length ? SangaWara.Values[sangaWaraId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    sangaWaraId = -1;
                    return;
                }
                
                sangaWaraId = value.Id;
            }
        }
        
        public DasaWara dasaWara
        {
            get
            {
                return dasaId >= 0 && dasaId < DasaWara.Values.Length ? DasaWara.Values[dasaId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    dasaId = -1;
                    return;
                }
                
                dasaId = value.Id;
            }
        }
        
        public Ingkel ingkel
        {
            get
            {
                return ingkelId >= 0 && ingkelId < Ingkel.Values.Length ? Ingkel.Values[ingkelId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    ingkelId = -1;
                    return;
                }
                
                ingkelId = value.Id;
            }
        }
        
        public Jejepan jejepan
        {
            get
            {
                return jejepanId >= 0 && jejepanId < Jejepan.Values.Length ? Jejepan.Values[jejepanId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    jejepanId = -1;
                    return;
                }
                
                jejepanId = value.Id;
            }
        }
        
        public Lintang lintang
        {
            get
            {
                return lintangId >= 0 && lintangId < Lintang.Values.Length ? Lintang.Values[lintangId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    lintangId = -1;
                    return;
                }
                
                lintangId = value.Id;
            }
        }
        
        public PancaSuda pancaSuda
        {
            get
            {
                return pancaSudaId >= 0 && pancaSudaId < PancaSuda.Values.Length ? PancaSuda.Values[pancaSudaId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    pancaSudaId = -1;
                    return;
                }
                
                pancaSudaId = value.Id;
            }
        }
        
        public Pararasan pararasan
        {
            get
            {
                return pararasanId >= 0 && pararasanId < Pararasan.Values.Length ? Pararasan.Values[pararasanId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    pararasanId = -1;
                    return;
                }
                
                pararasanId = value.Id;
            }
        }
        
        public WatekAlit watekAlit
        {
            get
            {
                return watekAlitId >= 0 && watekAlitId < WatekAlit.Values.Length ? WatekAlit.Values[watekAlitId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    watekAlitId = -1;
                    return;
                }
                
                watekAlitId = value.Id;
            }
        }
        
        public WatekMadya watekMadya
        {
            get
            {
                return watekMadyaId >= 0 && watekMadyaId < WatekMadya.Values.Length ? WatekMadya.Values[watekMadyaId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    watekMadyaId = -1;
                    return;
                }
                
                watekMadyaId = value.Id;
            }
        }
        
        public Rakam rakam
        {
            get
            {
                return rakamId >= 0 && rakamId < Rakam.Values.Length ? Rakam.Values[rakamId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    rakamId = -1;
                    return;
                }
                
                rakamId = value.Id;
            }
        }
        
        public EkaJalaRsi ekaJalaRsi
        {
            get
            {
                return ekaJalaRsiId >= 0 && ekaJalaRsiId < EkaJalaRsi.Values.Length ? EkaJalaRsi.Values[ekaJalaRsiId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    ekaJalaRsiId = -1;
                    return;
                }
                
                ekaJalaRsiId = value.Id;
            }
        }
        
        public Wuku wuku
        {
            get
            {
                return wukuId >= 0 && wukuId < Wuku.Values.Length ? Wuku.Values[wukuId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    wukuId = -1;
                    return;
                }
                
                wukuId = value.Id;
            }
        }
        
        public PratithiSamutPada pratithiSamutPada
        {
            get
            {
                return pratithiSamutPadaId >= 0 && pratithiSamutPadaId < PratithiSamutPada.Values.Length ? PratithiSamutPada.Values[pratithiSamutPadaId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    pratithiSamutPadaId = -1;
                    return;
                }
                
                pratithiSamutPadaId = value.Id;
            }
        }
        
        public Sasih sasih
        {
            get
            {
                return sasihId >= 0 && sasihId < Sasih.Values.Length ? Sasih.Values[sasihId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    sasihId = -1;
                    return;
                }
                
                sasihId = value.Id;
            }
        }
        
        public SasihDayInfo sasihDayInfo
        {
            get
            {
                return sasihDayInfoId >= 0 && sasihDayInfoId < SasihDayInfo.Values.Length ? SasihDayInfo.Values[sasihDayInfoId] : null;
            }
            
            set
            {
                if (value == null)
                {
                    sasihDayInfoId = -1;
                    return;
                }
                
                sasihDayInfoId = value.Id;
            }
        }
        
        public int ekaWaraId = -1;
        public int dwikaraId = -1;
        public int triWaraId = -1;
        public int caturWaraId = -1;
        public int pancaWaraId = -1;
        public int sadWaraId = -1;
        public int saptaWaraId = -1;
        public int astaWaraId = -1;
        public int sangaWaraId = -1;
        public int dasaId = -1;
        public int ingkelId = -1;
        public int jejepanId = -1;
        public int lintangId = -1;
        public int pancaSudaId = -1;
        public int pararasanId = -1;
        public int watekAlitId = -1;
        public int watekMadyaId = -1;
        public int rakamId = -1;
        public int ekaJalaRsiId = -1;
        public int wukuId = -1;
        public int pratithiSamutPadaId = -1;
        public int sasihId = -1;
        public int sasihDayInfoId = -1;
        public int[] sasihDay;
        public int saka = -1;
        public int[] dewasaIdList;

        public override string ToString()
        {
            var result = string.Empty;
            result += string.IsNullOrEmpty(ekaWara?.ToString()) ? string.Empty : ekaWara + " ";
            result += string.IsNullOrEmpty(dwiWara?.ToString()) ? string.Empty : dwiWara + " ";
            result += string.IsNullOrEmpty(triWara?.ToString()) ? string.Empty : triWara + " ";
            result += string.IsNullOrEmpty(caturWara?.ToString()) ? string.Empty : caturWara + " ";
            result += string.IsNullOrEmpty(pancaWara?.ToString()) ? string.Empty : pancaWara + " ";
            result += string.IsNullOrEmpty(sadWara?.ToString()) ? string.Empty : sadWara + " ";
            result += string.IsNullOrEmpty(saptaWara?.ToString()) ? string.Empty : saptaWara + " ";
            result += string.IsNullOrEmpty(astaWara?.ToString()) ? string.Empty : astaWara + " ";
            result += string.IsNullOrEmpty(sangaWara?.ToString()) ? string.Empty : sangaWara + " ";
            result += string.IsNullOrEmpty(dasaWara?.ToString()) ? string.Empty : dasaWara + " ";
            result += string.IsNullOrEmpty(ingkel?.ToString()) ? string.Empty : ingkel + " ";
            result += string.IsNullOrEmpty(jejepan?.ToString()) ? string.Empty : jejepan + " ";
            result += string.IsNullOrEmpty(lintang?.ToString()) ? string.Empty : lintang + " ";
            result += string.IsNullOrEmpty(pancaSuda?.ToString()) ? string.Empty : pancaSuda + " ";
            result += string.IsNullOrEmpty(pararasan?.ToString()) ? string.Empty : pararasan + " ";
            result += string.IsNullOrEmpty(watekAlit?.ToString()) ? string.Empty : watekAlit + " ";
            result += string.IsNullOrEmpty(watekMadya?.ToString()) ? string.Empty : watekMadya + " ";
            result += string.IsNullOrEmpty(rakam?.ToString()) ? string.Empty : rakam + " ";
            result += string.IsNullOrEmpty(ekaJalaRsi?.ToString()) ? string.Empty : ekaJalaRsi + " ";
            result += string.IsNullOrEmpty(wuku?.ToString()) ? string.Empty : wuku + " ";
            result += string.IsNullOrEmpty(sasih?.ToString()) ? string.Empty : sasih + " ";
            result += string.IsNullOrEmpty(sasihDayInfo?.ToString()) ? string.Empty : sasihDayInfo + " ";
            result += sasihDay == null ? string.Empty : string.Join("/", sasihDay) + " ";
            result += saka < 0 ? string.Empty : saka + " ";
            result += string.IsNullOrEmpty(pratithiSamutPada?.ToString()) ? string.Empty : pratithiSamutPada + " ";
            result.TrimEnd();
            return result;
        }
    }
}