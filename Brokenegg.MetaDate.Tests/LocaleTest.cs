using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brokenegg.MetaDate.Tests
{
    [TestClass]
    public class LocaleTest
    {
        [TestMethod]
        public void FindLocale()
        {
            var locale = ULocale.FindLocale("MANAUS");
            Assert.IsNotNull(locale);
        }

        [TestMethod]
        public void FindLocaleEnum()
        {
            var locale = ULocale.FindLocale(ELocales.MANAUS);
            Assert.IsNotNull(locale);
        }

        [TestMethod]
        public void FindWrongLocale()
        {
            var locale = ULocale.FindLocale("AMESTRIS");
            Assert.IsNull(locale);
        }
    }
}
