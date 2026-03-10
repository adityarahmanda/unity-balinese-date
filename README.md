
# BalineseDate Unity Library

## Introduction

BalineseDate is a open source library to develop Balinese Saka Calendar (Kalender Bali) in C# and Unity. This library is ported from Peradnya's Balinese Date javascript library (https://github.com/peradnya/balinese-date-js-lib).

> **Note**: This library is in **Beta Phase**, the API may change without notice.

## Features

BalineseDate is designed to be __immutable__. BalineseDate have several features like:

* [Pawukon](http://www.babadbali.com/pewarigaan/kalender-pawukon.htm)
* [Pawewaran](http://www.babadbali.com/pewarigaan/pawewaran.htm)
  * [EkaWara](http://www.babadbali.com/pewarigaan/ekawara.htm)
  * [DwiWara](http://www.babadbali.com/pewarigaan/dwiwara.htm)
  * [TriWara](http://www.babadbali.com/pewarigaan/triwara.htm)
  * [CaturWara](http://www.babadbali.com/pewarigaan/caturwara.htm)
  * [PancaWara](http://www.babadbali.com/pewarigaan/pancawara.htm)
  * [SadWara](http://www.babadbali.com/pewarigaan/sadwara.htm)
  * [SaptaWara](http://www.babadbali.com/pewarigaan/saptawara.htm)
  * [AstaWara](http://www.babadbali.com/pewarigaan/astawara.htm)
  * [SangaWara](http://www.babadbali.com/pewarigaan/sangawara.htm)
  * [DasaWara](http://www.babadbali.com/pewarigaan/dasawara.htm)
* [Paringkelan](http://www.babadbali.com/pewarigaan/paringkelan.htm)
  * [Jejepan](http://www.babadbali.com/pewarigaan/jejepan.htm)
  * [Ingkel](http://www.babadbali.com/pewarigaan/ingkel.htm)
  * [Pawatekan Madya & Alit](http://www.babadbali.com/pewarigaan/watek.htm)
  * [Lintang](http://www.babadbali.com/pewarigaan/lintang.htm)
  * [PancaSuda](http://www.babadbali.com/pewarigaan/pancasuda.htm)
  * [Pararasan](http://www.babadbali.com/pewarigaan/paarasan.htm)
  * [Rakam](http://www.babadbali.com/pewarigaan/rakam.htm)
* Eka Jala Rsi __(v0.3.0)__
* Pratithi Samut Pada __(v0.3.0)__
* Dewasa __(v0.5.0)__
* Sasih
  * Pawukon/Penanggal and Nguna Ratri.
  * Pengalantaka Eka Sungsang Pon (before 2000) & Paing (2000 and after)
  * Malamasa (< 1993), Sasih Kesinambungan (1993 - 2002), Nampih Sasih (>= 2003)
* [Saka Year](http://www.babadbali.com/pewarigaan/kalender-saka.htm)
* Rahinan __(v0.4.2)__

BalineseDate also have several utilities that can be use by developer like:

* Filter BalineseDate(s) from selected Date __(v0.2.0)__
* Filter BalineseDate(s) from selected BalineseDate List __(v0.4.0)__
* List of Rahinan given the BalineseDate __(v0.4.2)__

## Installation

### Install via Clone

1. Clone this project

```
git clone https://github.com/adityarahmanda/unity-balinese-date.git
```

2. Open the Project in Unity

### Install via .unitypackage Releases

1. Go to [Releases](https://github.com/adityarahmanda/unity-balinese-date/releases) page

2. Download latest `.unitypackage` from the latest release

3. Import the downloaded `.unitypackage` to your Unity project

### Install via Unity Package Manager

1. In Unity, Open `Edit -> Project Settings -> Package Manager`

2. Add a new Scoped Registry (or edit the existing OpenUPM entry)

    |Label|Value|
    |----|----|
    |Name|Aditya Rahmanda|
    |URL|https://package.openupm.com|
    |Scope(s)|com.adityarahmanda|

3. Click `Save` or `Apply`

4. Open Window/Package Manager

5. There are several ways to add the package

    - Go to My Registries section, 
    - Find `Aditya Rahmanda`'s `Balinese Date` package 
    - Click `Install` Button
  
    or

    - Click `+`
    - Select `Add package by name...`
    - Paste `com.adityarahmanda.balinese-date` into name
    - Click Add

## Using in Code

Below code is an example of how to use of BalineseDate:

```csharp
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
```
