using System.Globalization;
using TMPro;
using UnityEngine;

namespace BalineseCalendar.Sample
{
    public class BalineseDateSample : MonoBehaviour
    {
        public enum InputType { Today, Custom }
        
        [SerializeField] private TextMeshProUGUI dateInformationText;
        [SerializeField] private InputType inputType;
        [SerializeField] private int day;
        [SerializeField] private int month;
        [SerializeField] private int year;

        private void Awake()
        {
            var balineseDateToday = inputType == InputType.Today ? BalineseDate.Today : new BalineseDate(year, month, day);
            var dateInformation =
                $"<b>Kalender Bali {balineseDateToday.date.ToString("dddd, dd MMMM yyyy", new CultureInfo("id-ID"))}</b>\n\n" +
                $"<b>Penanggal:</b> {string.Join("/", balineseDateToday.sasihDay)}\n" +
                $"<b>Sasih:</b> {balineseDateToday.sasih}\n" +
                $"<b>Saka:</b> {balineseDateToday.saka}\n" +

                "\n<b>Pawukon</b>\n" +
                $"<b>Wuku:</b> {balineseDateToday.wuku}\n" +

                "\n<b>Waweran</b>\n" +
                $"<b>EkaWara:</b> {balineseDateToday.ekaWara}\n" +
                $"<b>DwiWara:</b> {balineseDateToday.dwiWara}\n" +
                $"<b>TriWara:</b> {balineseDateToday.triWara}\n" +
                $"<b>CaturWara:</b> {balineseDateToday.caturWara}\n" +
                $"<b>PancaWara:</b> {balineseDateToday.pancaWara}\n" +
                $"<b>SadWara:</b> {balineseDateToday.sadWara}\n" +
                $"<b>SaptaWara:</b> {balineseDateToday.saptaWara}\n" +
                $"<b>AstaWara:</b> {balineseDateToday.astaWara}\n" +
                $"<b>SangaWara:</b> {balineseDateToday.sangaWara}\n" +
                $"<b>DasaWara:</b> {balineseDateToday.dasaWara}\n" +

                "\n<b>Palelintangan</b>\n" +
                $"<b>Lintang:</b> {balineseDateToday.lintang}\n" +
                $"<b>Pancasuda:</b> {balineseDateToday.pancaSuda}\n" +
                $"<b>Pararasan:</b> {balineseDateToday.pararasan}\n" +

                "\n<b>Paringkelan</b>\n" +
                $"<b>Ingkel Pandakan:</b> {balineseDateToday.ingkel}\n" +
                $"<b>Ingkel Jejepan:</b> {balineseDateToday.jejepan}\n" +

                "\n<b>Wariga Lainnya</b>\n" +
                $"<b>Eka Jala Rsi:</b> {balineseDateToday.ekaJalaRsi}\n" +
                $"<b>Pratithi Samut Pada:</b> {balineseDateToday.pratithiSamutPada}\n" +
                $"<b>Watek Madya:</b> {balineseDateToday.watekMadya}\n" +
                $"<b>Watek Alit:</b> {balineseDateToday.watekAlit}\n" +
                $"<b>Rakam:</b> {balineseDateToday.rakam}\n" +

                "\n<b>Dewasa dan Rahinan</b>\n" +
                $"<b>Dewasa:</b> {string.Join(", ", balineseDateToday.GetDewasa())}\n" +
                $"<b>Rahinan:</b> {string.Join(", ", balineseDateToday.GetRahinan())}\n";
            dateInformationText.text = dateInformation;
        }
    }
}
