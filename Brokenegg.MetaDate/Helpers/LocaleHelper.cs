using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Brokenegg.MetaDate.Helpers
{
    public class LocaleHelper
    {
        public static List<ULocale> GetAllLocales() => ArchiveHelper.ReadXmlResource<ULocale>("timezones.xml", "locales");
    }
}
