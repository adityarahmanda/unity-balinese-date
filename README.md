
# BalineseDate Unity Library

## Introduction

BalineseDate is an open source library to develop Balinese Saka Calendar (Kalender Bali) in C# or Unity. This library is ported from [Peradnya's Balinese Date Java Library](https://github.com/peradnya/balinese-date-java-lib).

[![openupm](https://img.shields.io/npm/v/com.adityarahmanda.balinese-date?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.adityarahmanda.balinese-date/)

## Features

BalineseDate is designed to be __immutable__ and have several features like:

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
* Eka Jala Rsi
* Pratithi Samut Pada
* Dewasa
* Sasih
  * Pawukon/Penanggal and Nguna Ratri.
  * Pengalantaka Eka Sungsang Pon (before 2000) & Paing (2000 and after)
  * Malamasa (< 1993), Sasih Kesinambungan (1993 - 2002), Nampih Sasih (>= 2003)
* [Saka Year](http://www.babadbali.com/pewarigaan/kalender-saka.htm)
* Rahinan

BalineseDate also have several utilities that can be used by developers like:

* Filter BalineseDate(s) from selected Date
* Filter BalineseDate(s) from selected BalineseDate List
* List of Rahinan given the BalineseDate
* List of Dewasa given the BalineseDate

## Installation

### Install via Clone

1. Clone this project

```
git clone https://github.com/adityarahmanda/unity-balinese-date.git
```

2. Open the Project in Unity

### Install via .unitypackage Releases

1. Go to [Releases](https://github.com/adityarahmanda/unity-balinese-date/releases) page

2. Download `.unitypackage` from the latest release

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

Example output of the dateInformation would be

```
<b>Kalender Bali Selasa, 07 April 2026</b>

<b>Penanggal:</b> 5/6
<b>Sasih:</b> Kadasa
<b>Saka:</b> 1948

<b>Pawukon</b>
<b>Wuku:</b> Sinta

<b>Waweran</b>
<b>EkaWara:</b> Luang
<b>DwiWara:</b> Pepet
<b>TriWara:</b> Kajeng
<b>CaturWara:</b> Jaya
<b>PancaWara:</b> Wage
<b>SadWara:</b> Urukung
<b>SaptaWara:</b> Anggara
<b>AstaWara:</b> Guru
<b>SangaWara:</b> Dangu
<b>DasaWara:</b> Raja

<b>Palelintangan</b>
<b>Lintang:</b> Jung Sarat
<b>Pancasuda:</b> Lebu Katiup Angin
<b>Pararasan:</b> Laku Bumi

<b>Paringkelan</b>
<b>Ingkel Pandakan:</b> Wong
<b>Ingkel Jejepan:</b> Sato

<b>Wariga Lainnya</b>
<b>Eka Jala Rsi:</b> Manggih Suka
<b>Pratithi Samut Pada:</b> Jaramarana
<b>Watek Madya:</b> Watu
<b>Watek Alit:</b> Lembu
<b>Rakam:</b> Mantri Sinaroja

<b>Dewasa dan Rahinan</b>
<b>Dewasa:</b> Basah Gede, Carik Walangati, Salah Wadi, Banu Urung, Kala Empas, Kala Luang, Kala Sor, Titi Buwuk
<b>Rahinan:</b> Sabuh Emas
```