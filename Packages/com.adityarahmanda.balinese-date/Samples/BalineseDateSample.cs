using System.Globalization;
using TMPro;
using UnityEngine;

namespace BalineseCalendar.Sample
{
    public class BalineseDateSample : MonoBehaviour
    {
        public enum InputType
        {
            Today,
            Custom
        }
        
        [SerializeField] private TextMeshProUGUI dateInformationText;
        [SerializeField] private InputType inputType;
        [SerializeField] private int day;
        [SerializeField] private int month;
        [SerializeField] private int year;

        private void Awake()
        {
            var balineseDateNow = inputType == InputType.Today ? BalineseDate.Today : new BalineseDate(year, month, day);
            var balineseDateRahinan = balineseDateNow.GetRahinan();
            var dateInformation =
                $"<b>Kalender Bali {balineseDateNow.date.ToString("dddd, dd MMMM yyyy", new CultureInfo("id-ID"))}</b>\n\n" +
                $"<b>Penanggal:</b> {string.Join("/", balineseDateNow.sasihDay)}\n" +
                $"<b>Sasih:</b> {balineseDateNow.sasih}\n" +
                $"<b>Saka:</b> {balineseDateNow.saka}\n" +

                "\n<b>Pawukon</b>\n" +
                $"<b>Wuku:</b> {balineseDateNow.wuku}\n" +

                "\n<b>Waweran</b>\n" +
                $"<b>EkaWara:</b> {balineseDateNow.ekaWara}\n" +
                $"<b>DwiWara:</b> {balineseDateNow.dwiWara}\n" +
                $"<b>TriWara:</b> {balineseDateNow.triWara}\n" +
                $"<b>CaturWara:</b> {balineseDateNow.caturWara}\n" +
                $"<b>PancaWara:</b> {balineseDateNow.pancaWara}\n" +
                $"<b>SadWara:</b> {balineseDateNow.sadWara}\n" +
                $"<b>SaptaWara:</b> {balineseDateNow.saptaWara}\n" +
                $"<b>AstaWara:</b> {balineseDateNow.astaWara}\n" +
                $"<b>SangaWara:</b> {balineseDateNow.sangaWara}\n" +
                $"<b>DasaWara:</b> {balineseDateNow.dasaWara}\n" +

                "\n<b>Palelintangan</b>\n" +
                $"<b>Lintang:</b> {balineseDateNow.lintang}\n" +
                $"<b>Pancasuda:</b> {balineseDateNow.pancaSuda}\n" +
                $"<b>Pararasan:</b> {balineseDateNow.pararasan}\n" +

                "\n<b>Paringkelan</b>\n" +
                $"<b>Ingkel Pandakan:</b> {balineseDateNow.ingkel}\n" +
                $"<b>Ingkel Jejepan:</b> {balineseDateNow.jejepan}\n" +

                "\n<b>Lainnya</b>\n" +
                $"<b>Eka Jala Rsi:</b> {balineseDateNow.ekaJalaRsi}\n" +
                $"<b>Pratithi Samut Pada:</b> {balineseDateNow.pratithiSamutPada}\n" +
                $"<b>Watek Madya:</b> {balineseDateNow.watekMadya}\n" +
                $"<b>Watek Alit:</b> {balineseDateNow.watekAlit}\n" +
                $"<b>Rakam:</b> {balineseDateNow.rakam}\n" +
                
                "\n<b>Rahinan</b>\n" +
                $"<b>Rahinan:</b> {string.Join(",", balineseDateRahinan)}\n";
            dateInformationText.text = dateInformation;
        }
    }
}
