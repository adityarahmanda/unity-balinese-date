
# BalineseDate Unity Library

## Introduction

BalineseDate is a open source library to develop Balinese Saka Calendar (Kalender Bali) in C# and Unity. This library is ported and modified further from Peradnya's [Balinese Date Java Library](https://github.com/peradnya/balinese-date-java-lib).

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
* List of Dewasa's suitable and unsuitable activities
* List of Sasih's suitable and unsuitable activities

## Installation

### Install via Clone

Clone this project using this command line

```
git clone https://github.com/adityarahmanda/unity-balinese-date.git
```

### Install via Git Url

1. Open Unity Package Manager

2. Click `+`

3. Select `Add package from git URL...`

4. Paste this URL

```
https://github.com/adityarahmanda/unity-balinese-date.git?path=/Packages/com.adityarahmanda.balinese-date
```

5. Click Add

### Install via Tarball Releases

1. Go to [Releases](https://github.com/adityarahmanda/unity-balinese-date/releases) page

2. Download `.tgz` from the latest release

3. In Unity, open Window/Package Manager

    - Click `+`
    - Select `Add package by tarball...`
    - Select the downloaded `com.adityarahmanda.balinese-date` to import it

### Install via Scoped Registry

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
```

Example output of the dateInformation would be

```
<b>Kalender Bali Selasa, 07 April 2026</b>

<b>Pangelong:</b> 5/6
<b>Sasih:</b> Kadasa
Baik untuk: Dewa Yadnya, Manusa Yadnya, Rsi Yadnya
Tidak baik untuk: Pitra Yadnya
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

<b>Daftar Dewasa:</b>
# <b>Banyu Urug</b>
Baik untuk: Membuat kolam atau bendungan
Tidak baik untuk: Membuat sumur
# <b>Carik Walangati</b>
Tidak baik untuk: Pitra Yadnya, Manusa Yadnya, Membuat bangunan
# <b>Gagak Anungsang Pati</b>
Tidak baik untuk: Pitra Yadnya
# <b>Kala Empas Munggah</b>
Baik untuk: Membuat bangunan
Tidak baik untuk: Memetik buah-buahan
# <b>Kala Jangkut</b>
Baik untuk: Membuat jala, Membuat senjata
# <b>Kala Klingkung</b>
Tidak baik untuk: Mencuri demi kepentingan umum yang bertujuan baik
# <b>Kala Luang</b>
Baik untuk: Menanam umbi-umbian (kentang, kacang, dan lainnya), Membuat saluran air (got, terowongan, irigasi, dan lainnya)
# <b>Kala Sor</b>
Tidak baik untuk: Menggarap sawah atau ladang, Bercocok tanam
# <b>Kala Timpang</b>
Baik untuk: Membuat senjata, Membuat jebakan hewan, Memasang guna-guna, Membuat/meramu obat-obatan
Tidak baik untuk: Berburu
# <b>Pepedan</b>
Baik untuk: Menggarap sawah atau ladang
Tidak baik untuk: Membuat alat dari besi
# <b>Salah Wadi</b>
Tidak baik untuk: Pitra Yadnya, Manusa Yadnya
# <b>Tali Wangke</b>
Baik untuk: Membuat pagar, Memasang tali penghambat di ladang, Membuat tali pengikat padi, Membuat tali pengikat benda-benda mati
Tidak baik untuk: Membuat tali ternak, Mengerjakan benang tenun
# <b>Titi Buwuk</b>
Baik untuk: Menghilangkan kekuatan negatif
Tidak baik untuk: Melakukan berpergian, Melakukan kegiatan penting, Membuat tangga

<b>Daftar Rahinan:</b> Sabuh Emas
```