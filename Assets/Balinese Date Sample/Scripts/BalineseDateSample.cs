using System.Globalization;
using BalineseCalendar;
using TMPro;
using UnityEngine;

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
        var balineseDate = inputType == InputType.Today ? BalineseDate.Today : new BalineseDate(year, month, day);
        var balineseDateDewasa = balineseDate.GetDewasa();
        var balineseDateRahinan = balineseDate.GetRahinan();
        var dateInformation =
            $"<b>Kalender Bali {balineseDate.date.ToString("dddd, dd MMMM yyyy", new CultureInfo("id-ID"))}</b>\n\n" +
            $"<b>{balineseDate.sasihDayInfo}:</b> {string.Join("/", balineseDate.sasihDay)}\n";

        dateInformation += $"<b>Sasih:</b> {balineseDate.sasih}\n";
        var sasihData = balineseDate.sasih.GetSasihData();
        if (sasihData != null)
        {
            if (sasihData.SuitableActivityList != null && sasihData.SuitableActivityList.Length > 0)
                dateInformation += "Baik untuk: " + string.Join(", ", sasihData.SuitableActivityList) + "\n";
            
            if (sasihData.UnsuitableActivityList != null && sasihData.UnsuitableActivityList.Length > 0)
                dateInformation += "Tidak baik untuk: " + string.Join(", ", sasihData.UnsuitableActivityList) + "\n";
        }

        dateInformation += $"<b>Saka:</b> {balineseDate.saka}\n";

        dateInformation += "\n<b>Pawukon</b>\n" +
                           $"<b>Wuku:</b> {balineseDate.wuku}\n";

        dateInformation += "\n<b>Waweran</b>\n" +
                           $"<b>EkaWara:</b> {balineseDate.ekaWara}\n" +
                           $"<b>DwiWara:</b> {balineseDate.dwiWara}\n" +
                           $"<b>TriWara:</b> {balineseDate.triWara}\n" +
                           $"<b>CaturWara:</b> {balineseDate.caturWara}\n" +
                           $"<b>PancaWara:</b> {balineseDate.pancaWara}\n" +
                           $"<b>SadWara:</b> {balineseDate.sadWara}\n" +
                           $"<b>SaptaWara:</b> {balineseDate.saptaWara}\n" +
                           $"<b>AstaWara:</b> {balineseDate.astaWara}\n" +
                           $"<b>SangaWara:</b> {balineseDate.sangaWara}\n" +
                           $"<b>DasaWara:</b> {balineseDate.dasaWara}\n";

        dateInformation += "\n<b>Palelintangan</b>\n" +
                           $"<b>Lintang:</b> {balineseDate.lintang}\n" +
                           $"<b>Pancasuda:</b> {balineseDate.pancaSuda}\n" +
                           $"<b>Pararasan:</b> {balineseDate.pararasan}\n";

        dateInformation += "\n<b>Paringkelan</b>\n" +
                           $"<b>Ingkel Pandakan:</b> {balineseDate.ingkel}\n" +
                           $"<b>Ingkel Jejepan:</b> {balineseDate.jejepan}\n";

        dateInformation += "\n<b>Wariga Lainnya</b>\n" +
                           $"<b>Eka Jala Rsi:</b> {balineseDate.ekaJalaRsi}\n" +
                           $"<b>Pratithi Samut Pada:</b> {balineseDate.pratithiSamutPada}\n" +
                           $"<b>Watek Madya:</b> {balineseDate.watekMadya}\n" +
                           $"<b>Watek Alit:</b> {balineseDate.watekAlit}\n" +
                           $"<b>Rakam:</b> {balineseDate.rakam}\n";

        dateInformation += "\n<b>Daftar Dewasa:</b>\n";
        foreach (var dewasa in balineseDateDewasa)
        {
            dateInformation += $"# <b>{dewasa}</b>\n";
            var dewasaData = dewasa.GetDewasaData();
            if (dewasaData == null) continue;
            
            if (dewasaData.SuitableActivityList != null && dewasaData.SuitableActivityList.Length > 0)
                dateInformation += "Baik untuk: " + string.Join(", ", dewasaData.SuitableActivityList) + "\n";
            
            if (dewasaData.UnsuitableActivityList != null && dewasaData.UnsuitableActivityList.Length > 0)
                dateInformation += "Tidak baik untuk: " + string.Join(", ", dewasaData.UnsuitableActivityList) + "\n";
        }

        dateInformation += "\n<b>Daftar Rahinan:</b> " + string.Join(", ", balineseDateRahinan) + "\n";
        dateInformationText.text = dateInformation;
    }
}
