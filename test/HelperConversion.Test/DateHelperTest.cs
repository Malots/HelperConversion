using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HelperConversion.Test
{
    [TestClass]
    public class DateHelperTest
    {
        [TestMethod]
        [TestCategory("Age")]
        public void GiveAValidYearsReturnAge()
        {
            DateTime year = DateTime.Now;
            Assert.Equals(33,year.Age());
        }
    }
}
