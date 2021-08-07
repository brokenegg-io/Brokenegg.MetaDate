using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Brokenegg.MetaDate.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDateConversion()
        {
            USettings.Locale = ULocale.FindLocale(ELocales.MANAUS);

            var date = DateTime.Now;

            var dateUtc = new UDate(date).ToUtcDateTime();
            var dateLocal = new UDate(date).ToLocalDateTime();

            Assert.IsTrue((dateUtc - dateLocal).Hours == 3);
        }
    }
}
