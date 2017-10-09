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
        #region Date Heper
        [TestMethod]
        [TestCategory("Date Helper")]
        public void GiveAValidBirthdateReturnAge()
        {
            DateTime date = new DateTime(1984, 11, 15);
            Assert.IsTrue(date.GetAge() >= 32);
        }

        [TestMethod]
        [TestCategory("Date Helper")]
        public void GiveAInvalidBirthdateReturnNegativeAge()
        {
            DateTime date = new DateTime(DateTime.Now.Year + 15, 11, 15);
            Assert.IsTrue(date.GetAge() < 0);
        }

        [TestMethod]
        [TestCategory("Date Helper")]
        public void GiveATodayBirthdateReturnZeroAge()
        {
            DateTime date = DateTime.Now;
            Assert.IsTrue(date.GetAge() == 0);
        }

        [TestMethod]
        [TestCategory("Date Helper")]
        public void GetDaysBetweenTwoValidDates()
        {
            DateTime current = DateTime.UtcNow;
            DateTime another = DateTime.UtcNow.AddDays(10);
            Assert.AreEqual(10, current.GetDaysBetween(another));
        }

        [TestMethod]
        [TestCategory("Date Helper")]
        public void GetDaysBetweenTwoInvalidDates()
        {
            DateTime current = DateTime.UtcNow;
            DateTime another = DateTime.UtcNow.AddDays(-11);
            Assert.AreNotEqual(11, current.GetDaysBetween(another));
        }
        #endregion

        #region String Helper
        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidStringIntegerValueReturnInteger32()
        {
            string value = "10";
            Assert.AreEqual(10, value.ToInt32());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAInvalidStringIntegerValueReturnDefaultInteger32()
        {
            string value = "abc";
            Assert.AreEqual(5, value.ToInt32(5));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidStringIntegerValueReturnInteger64()
        {
            string value = "10";
            Assert.AreEqual(10, value.ToInt64());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAInvalidStringIntegerValueReturnDefaultInteger64()
        {
            string value = "abc";
            Assert.AreEqual(5, value.ToInt64(5));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidBoolStringValueReturnBoolValue()
        {
            string value = "True";
            Assert.AreEqual(true, value.ToBool());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAInvalidBoolStringValueReturnDefaultBool()
        {
            string value = "abc";
            Assert.AreEqual(false, value.ToBool(false));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidFloatStringValueReturnFloat()
        {
            string value = "10,5";
            Assert.AreEqual(10.5f, value.ToFloat());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAInvalidFloatStringValueReturnDefaultFloat()
        {
            string value = "abc";
            Assert.AreEqual(15.5f, value.ToFloat(15.5f));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidIpStringValueReturnIp()
        {
            string value = "192.168.1.1";
            IPAddress ip = null;
            IPAddress.TryParse(value, out ip);
            Assert.AreEqual(ip, value.ToIp());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAInvalidIpStringValueReturnIpDefault()
        {
            string value = "192.168.1.1";
            IPAddress defaultIp = null;
            IPAddress.TryParse(value, out defaultIp);
            value = "abc";
            Assert.AreEqual(IPAddress.Parse("192.168.1.1"), value.ToIp(defaultIp));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidByteStringValueReturnByte()
        {
            string value = "word";
            byte[] expected = Encoding.UTF8.GetBytes(value);
            Assert.IsTrue(value.ToByteUTF8().SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAInvalidByteStringValueReturnByteDefault()
        {
            string value = "word";
            byte[] expected = Encoding.UTF8.GetBytes(value);
            value = null;
            Assert.IsTrue(value.ToByteUTF8(expected).SequenceEqual(expected));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidNumbersInStringValueReturnNumbers()
        {
            string word = "Abdc1234yuf";
            Assert.AreEqual("1234", word.GetOnlyNumbers());
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
        public void GiveAValidStringReturnReversed()
        {
            string word = "Brasil";
            Assert.AreEqual("lisarB", word.ReverseString());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidDateStringReturnDate()
        {
            string word = "05/09/2017";
            Assert.AreEqual(new DateTime(2017, 09, 05), word.ToDate());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAInvalidDateStringReturnDefaultDate()
        {
            string word = "AB/XY/2017";
            Assert.AreEqual(new DateTime(2017, 09, 05), word.ToDate(new DateTime(2017, 09, 05)));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidStringReturnDouble()
        {
            string value = "10,5";
            Assert.AreEqual(10.5, value.ToDouble());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAInvalidStringReturnDoubleDefault()
        {
            string value = "ABC";
            Assert.AreEqual(10.5, value.ToDouble(10.5));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidStringReturnDecimal()
        {
            string value = "10,5";
            Assert.AreEqual(10.5m, value.ToDecimal());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAInvalidStringReturnDecimalDefault()
        {
            string value = "ABC";
            Assert.AreEqual(10.5m, value.ToDecimal(10.5m));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAValidStringValueReturnFalseForEmpty()
        {
            string value = "word";
            Assert.IsFalse(value.IsEmpty());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAEmptyStringValueReturnTrueForEmpty()
        {
            string value = "";
            Assert.IsTrue(value.IsEmpty());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAStringWithMaskThenRemoveTheMask()
        {
            string mask = "ABC.765-894.678-00";
            Assert.AreEqual("ABC76589467800", mask.RemoveMask());
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAStringGetValueBetweenValidStrings()
        {
            string str = "strstartvaluestrend";
            Assert.AreEqual("value", str.GetStringBetween("strstart", "strend"));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAStringGetValueBetweenInvalidStrings()
        {
            string str = "strstartvaluestrend";
            Assert.AreNotEqual("value", str.GetStringBetween("invalid", "string"));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAStringGetValueAfterValidSubtring()
        {
            string str = "strstartvaluestrend";
            Assert.AreEqual("strend",str.GetAfter("value"));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAStringGetValueAfterInvalidSubtring()
        {
            string str = "strstartvaluestrend";
            Assert.AreNotEqual("strend", str.GetAfter("invalid"));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAStringGetValueBeforeValidSubtring()
        {
            string str = "strstartvaluestrend";
            Assert.AreEqual("strstart", str.GetBefore("value"));
        }

        [TestMethod]
        [TestCategory("String Helper")]
        public void GiveAStringGetValueBeforeInvalidSubtring()
        {
            string str = "strstartvaluestrend";
            Assert.AreNotEqual("strstart", str.GetBefore("invalid"));
        }
        #endregion

        #region Bool Helper
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
        [TestCategory("Bool Helper")]
        public void GiveATrueBoolReturnCharValue()
        {
            bool value = true;
            Assert.AreEqual('1', value.ToChar());
        }
        #endregion

        #region Byte Helper
        [TestMethod]
        [TestCategory("Byte Helper")]
        public void GenerateValidByteKey()
        {
            byte[] value = ("word").ToByteUTF8();
            Assert.IsFalse(value.SequenceEqual(value.GenerateKey()));
        }

        [TestMethod]
        [TestCategory("Byte Helper")]
        public void CombiteTwoBytes()
        {
            byte[] valueOne = ("wordOne").ToByteUTF8();
            byte[] valueTwo = ("wordTwo").ToByteUTF8();
            Assert.IsFalse(valueOne.SequenceEqual(valueOne.Combine(valueTwo)));
        }

        [TestMethod]
        [TestCategory("Byte Helper")]
        public void GiveAValidByteReturnStringValue()
        {
            byte[] value = ("wordOne").ToByteUTF8();
            Assert.AreEqual("wordOne",value.ToStringUTF8());
        }
        #endregion

        #region Char Helper
        [TestMethod]
        [TestCategory("Char Helper")]
        public void GiveAValidCharReturnIntValue()
        {
            char value = '1';
            Assert.AreEqual(1, value.ToInt());
        }

        [TestMethod]
        [TestCategory("Char Helper")]
        public void GiveAinvalidCharReturnIntValueDef()
        {
            char value = 'D';
            Assert.AreEqual(10, value.ToInt(10));
        }

        [TestMethod]
        [TestCategory("Char Helper")]
        public void GiveAValidCharReturnBoolValueTrue()
        {
            char value = '1';
            Assert.IsTrue(value.ToBool());
        }
        [TestMethod]
        [TestCategory("Char Helper")]
        public void GiveAInvalidCharReturnBoolFalse()
        {
            char value = 'C';
            Assert.IsFalse(value.ToBool());
        }
        #endregion

        #region Array Helper
        [TestMethod]
        [TestCategory("Array Helper")]
        public void GiveArrayWithAnyContentReturnTrue()
        {
            string[] array = { "valueOne" , "valueTwo" };
            Assert.IsFalse(array.IsNullOrEmpty());
        }

        [TestMethod]
        [TestCategory("Array Helper")]
        public void GiveArrayWithNoContentReturnTrue()
        {
            string[] array = { };
            Assert.IsTrue(array.IsNullOrEmpty());
        }
        #endregion
    }
}
