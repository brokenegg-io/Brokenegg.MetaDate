using Brokenegg.MetaDate.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Brokenegg.MetaDate
{
    [XmlRoot("locales")]
    public class ULocale
    {
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("hours")]
        public int Hours { get; set; }
        [XmlElement("minutes")]
        public int Minutes { get; set; }

        public static List<ULocale> GetLocales() => LocaleHelper.GetAllLocales();
        public static ULocale FindLocale(string name) => FindByName(name);
        public static ULocale FindLocale(ELocales locale) => FindByName(locale.ToString());
        private static ULocale FindByName(string name) =>
            LocaleHelper.GetAllLocales()
            .Where(p => p.Name.Equals(name.ToUpper()))
            .FirstOrDefault();
    }
}
