# Brokenegg.MetaDate


![GitHub License](https://img.shields.io/github/license/brokenegg-io/Brokenegg.MetaDate)
[![Version](https://img.shields.io/badge/version-0.0.1.RC-red.svg)](https://semver.org)
![Actions](https://github.com/brokenegg-io/Brokenegg.MetaDate/actions/workflows/ci.yml/badge.svg)
![Actions](https://github.com/brokenegg-io/Brokenegg.MetaDate/actions/workflows/release.yml/badge.svg)
![GitHub branch checks state](https://img.shields.io/github/checks-status/brokenegg-io/Brokenegg.MetaDate/dev)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/brokenegg-io/Brokenegg.MetaDate)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Brokenegg.MetaDate.svg)](https://www.nuget.org/packages/Brokenegg.MetaDate/)
[![GitHub Contributors](https://img.shields.io/github/contributors/brokenegg-io/Brokenegg.MetaDate)](https://github.com/brokenegg-io/Brokenegg.MetaDate/graphs/contributors)
            
Standarize the date across all your projects using this library. Library created for applications who needs to have a precise date and time on different timezones and locations.

## Installation

Our profile on the NuGet library [brokenegg.io](https://www.nuget.org/profiles/brokenegg.io)

Use the package manager [NuGet](https://www.nuget.org/) to install DotIni.

```bash
nuget install brokenegg.metadate
```

## Usage

```csharp
using System.IO;
using Brokenegg.MetaDate;
```

### Setting global Locale 

Setting global Time Zone as `Manaus Time Zone (UTC-4)`

```csharp
USettings.Locale = ULocale.FindLocale(ELocales.MANAUS);
```

Converting date local to UTC (back and forth)

```csharp
var date = DateTime.ParseExact("25/10/2021 20:25", "dd/MM/yyyy HH:mm", null);

var uDate = new UDate(date);
            
var local =  uDate.ToLocalDateTime();
var utc = uDate.ToUtcDateTime();
```

`local` should be the date 25/10/2021 20:25

`utc`  should be the date 26/10/2021 00:25

### Using local as on an each case basis

You can use different locales for each date you want, instead of using a global setting, as shown bellow:

```csharp
var date = DateTime.ParseExact("25/10/2021 20:25", "dd/MM/yyyy HH:mm", null);

var uDate = new UDate(date, ULocale.FindLocale(ELocales.MANAUS));
            
var local =  uDate.ToLocalDateTime();
var utc = uDate.ToUtcDateTime();
```

`local` should be the date 25/10/2021 20:25

`utc`  should be the date 26/10/2021 00:25

We have prepared the repo [Brokenegg.MetaDate.Example](https://github.com/brokenegg-io/Brokenegg.MetaDate.Example) which contains some usefull examples.

## Contributing

If you didn't find your timezone listed on the xml file at `Brokenegg.MetaDate.timezones.xml` please open an issue or set up a pull request to the main branch and we will gladly integrate it. Remember to use `_` to separate each word if your timezone has more than one word.
Example of how the timezones is structured:

```xml
<locales>
    <locale>
        <name>MANAUS</name>
        <hours>-4</hours>
        <minutes>0</minutes>
    </locale>
<locales>    
```

And add the enum for your Timezone on the enum `Brokenegg.MetaDate.ELocales` :

```csharp
public enum ELocales
{
   MANAUS,
}
````

Please make sure to update tests as appropriate.

[get@brokenegg.io](mailto:get@brokenegg.io)

## License
[MIT](https://choosealicense.com/licenses/mit/)
