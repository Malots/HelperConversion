using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HelperConversion.Test
{
    [TestClass]
    public class UsageTest
    {
        [TestMethod]
        [TestCategory("Date Helper")]
        public void GiveAValidBirthdateReturnAge()
        {
            DateTime date = new DateTime(1984, 11, 15);
            Assert.IsTrue(date.Age() >= 32);
        }

        [TestMethod]
        [TestCategory("Date Helper")]
        public void GiveAInvalidBirthdateReturnNegativeAge()
        {
            DateTime date = new DateTime(DateTime.Now.Year+15, 11, 15);
            Assert.IsTrue(date.Age() < 0);
        }

        [TestMethod]
        [TestCategory("Date Helper")]
        public void GiveATodayBirthdateReturnZeroAge()
        {
            DateTime date = DateTime.Now;
            Assert.IsTrue(date.Age() == 0);
        }
    }
}
