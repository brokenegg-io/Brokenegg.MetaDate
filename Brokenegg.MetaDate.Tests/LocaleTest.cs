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
            Assert.IsTrue(true);
        }
    }
}
