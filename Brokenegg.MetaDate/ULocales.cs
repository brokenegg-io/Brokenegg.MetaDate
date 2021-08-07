using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Brokenegg.MetaDate
{
    [XmlRoot(ElementName = "locales")]
    public class ULocales
    {
        [XmlElement(ElementName = "locale")]
        public List<ULocale> Locale { get; set; }
    }
}
