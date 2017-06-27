using Microsoft.VisualStudio.TestTools.UnitTesting;
using JSRomanNumerals;

namespace JSRomanNumeralsTest
{
    [TestClass]
    public class TestRomanNumbers
    {
        [TestMethod]
        public void Test_ConvertNumber0()
        {
            var romanConverter = new RomanConverter();

            var romanNumber = romanConverter.Convert(0);

            Assert.AreEqual("", romanNumber);
        }

        [TestMethod]
        public void Test_ConvertNumber1()
        {
            var romanConverter = new RomanConverter();

            var romanNumber = romanConverter.Convert(1);

            Assert.AreEqual("I", romanNumber);
        }

        [TestMethod]
        public void Test_ConvertNumber4()
        {
            var romanConverter = new RomanConverter();

            var romanNumber = romanConverter.Convert(4);

            Assert.AreEqual("IV", romanNumber);
        }

        [TestMethod]
        public void Test_ConvertNumber9()
        {
            var romanConverter = new RomanConverter();

            var romanNumber = romanConverter.Convert(9);

            Assert.AreEqual("IX", romanNumber);
        }

        [TestMethod]
        public void Test_ConvertNumber90()
        {
            var romanConverter = new RomanConverter();

            var romanNumber = romanConverter.Convert(90);

            Assert.AreEqual("XC", romanNumber);
        }

        [TestMethod]
        public void Test_ConvertNumber98()
        {
            var romanConverter = new RomanConverter();

            var romanNumber = romanConverter.Convert(98);

            Assert.AreEqual("XCVIII", romanNumber);
        }

        [TestMethod]
        public void Test_ConvertNumber1001()
        {
            var romanConverter = new RomanConverter();

            var romanNumber = romanConverter.Convert(1001);

            Assert.AreEqual("MI", romanNumber);
        }

        [TestMethod]
        public void Test_ConvertNumber1982()
        {
            var romanConverter = new RomanConverter();

            var romanNumber = romanConverter.Convert(1982);

            Assert.AreEqual("MCMLXXXII", romanNumber);
        }

        [TestMethod]
        public void Test_ConvertNumber3999()
        {
            var romanConverter = new RomanConverter();

            var romanNumber = romanConverter.Convert(3999);

            Assert.AreEqual("MMMCMXCIX", romanNumber);
        }
    }
}
