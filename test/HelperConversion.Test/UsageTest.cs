using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Net;
using System.Text;

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

        [TestMethod]
        [TestCategory("Date Helper")]
        public void GetDaysBetweenTwoValidDates()
        {
            DateTime current = DateTime.UtcNow;
            DateTime another = DateTime.UtcNow.AddDays(10);
            Assert.AreEqual(10, current.DaysBetween(another));
        }

        [TestMethod]
        [TestCategory("Date Helper")]
        public void GetDaysBetweenTwoInvalidDates()
        {
            DateTime current = DateTime.UtcNow;
            DateTime another = DateTime.UtcNow.AddDays(-11);
            Assert.AreNotEqual(11, current.DaysBetween(another));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidStringIntegerValueReturnInteger()
        {
            string value = "10";
            Assert.AreEqual(10, value.ToIntDef());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAInvalidStringIntegerValueReturnDefaultInteger()
        {
            string value = "abc";
            Assert.AreEqual(5, value.ToIntDef(5));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidBoolStringValueReturnBoolValue()
        {
            string value = "True";
            Assert.AreEqual(true, value.ToBoolDef());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAInvalidBoolStringValueReturnDefaultBool()
        {
            string value = "abc";
            Assert.AreEqual(false, value.ToBoolDef(false));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidFloatStringValueReturnFloat()
        {
            string value = "10,5";
            Assert.AreEqual(10.5f, value.ToFloatDef());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAInvalidFloatStringValueReturnDefaultFloat()
        {
            string value = "abc";
            Assert.AreEqual(15.5f, value.ToFloatDef(15.5f));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidIpStringValueReturnIp()
        {
            string value = "192.168.1.1";
            IPAddress ip = null;
            IPAddress.TryParse(value,out ip);
            Assert.AreEqual(ip,value.ToIpDef());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAInvalidIpStringValueReturnIpDefault()
        {
            string value = "192.168.1.1";
            IPAddress defaultIp = null;
            IPAddress.TryParse(value, out defaultIp);
            value = "abc";
            Assert.AreEqual(IPAddress.Parse("192.168.1.1"), value.ToIpDef(defaultIp));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidByteStringValueReturnByte()
        {
            string value = "word";
            byte[] expected = Encoding.UTF8.GetBytes(value);
            Assert.IsTrue(value.ToByteUTF8Def().SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAInvalidByteStringValueReturnByteDefault()
        {
            string value = "word";
            byte[] expected = Encoding.UTF8.GetBytes(value);
            value = null;
            Assert.IsTrue(value.ToByteUTF8Def(expected).SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidNumbersInStringValueReturnNumbers()
        {
            string word = "Abdc1234yuf";
            Assert.AreEqual("1234",word.GetOnlyNumbers());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAOnlyLettersStringValueReturnEmpty()
        {
            string word = "UhuhauhayBBAA";
            Assert.AreEqual("", word.GetOnlyNumbers());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveNullStringValueReturnEmpty()
        {
            string word = null;
            Assert.AreEqual("", word.GetOnlyNumbers());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidStringReturnHashValue()
        {
            string value = "value";
            byte[] key = ("key").ToByteUTF8Def();
            Assert.AreNotEqual("", value.HashSha256(key));
        }

        [TestMethod]
        [TestCategory("Bool Helper")]
        public void GiveATrueBoolReturnStringValue()
        {
            string valueOne = "value";
            string valuetwo = "value";
            Assert.AreEqual("true", (valueOne == valuetwo).IfThen("true", "false"));
        }

        [TestMethod]
        [TestCategory("Bool Helper")]
        public void GiveAFalseBoolReturnStringValue()
        {
            string valueOne = "value";
            string valuetwo = "value_";
            Assert.AreEqual("false", (valueOne == valuetwo).IfThen("true", "false"));
        }

        [TestMethod]
        [TestCategory("Byte Helper")]
        public void GenerateValidByteKey()
        {
            byte[] value = ("word").ToByteUTF8Def();
            Assert.IsFalse(value.SequenceEqual(value.GenerateKey()));
        }

        [TestMethod]
        [TestCategory("Byte Helper")]
        public void CombiteTwoBytes()
        {
            byte[] valueOne = ("wordOne").ToByteUTF8Def();
            byte[] valueTwo = ("wordTwo").ToByteUTF8Def();
            Assert.IsFalse(valueOne.SequenceEqual(valueOne.Combine(valueTwo)));
        }

        [TestMethod]
        [TestCategory("Byte Helper")]
        public void GiveAValidByteReturnStringValue()
        {
            byte[] value = ("wordOne").ToByteUTF8Def();
            Assert.AreEqual("wordOne",value.ToStringUTF8Def());
        }
    }
}
