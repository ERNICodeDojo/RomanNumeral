using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;

namespace RomanNumeralsTest
{

    [TestClass]
    public class RomanTest
    {
        /// <summary>
        /// Romans the numeral is not null.
        /// </summary>
        [TestMethod]
        public void RomanNumeral_IsNotNull()
        {
            // Arrange
            var romanNumeral = new RomanNumeral();

            // Act
            // Assert
            Assert.IsNotNull(romanNumeral);
        }

        /// <summary>
        ///  
        /// </summary>
        [TestMethod]
        public void RomanNumeral_GetNumber1FromArabic()
        {
            // Arrange
            var romanNumeral = new RomanNumeral();

            // Act
            var romanNumeralValue = romanNumeral.GetRomanValueFromArabicNum(1);

            // Assert
            Assert.AreEqual("I", romanNumeralValue);
        }

        /// <summary>
        ///  
        /// </summary>
        [TestMethod]
        public void RomanNumeral_GetNumber3FromArabic()
        {
            // Arrange
            var romanNumeral = new RomanNumeral();

            // Act
            var romanNumeralValue = romanNumeral.GetRomanValueFromArabicNum(3);

            // Assert
            Assert.AreEqual("III", romanNumeralValue);
        }

        [TestMethod]
        public void RomanNumeral_GetNumber4FromArabic()
        {
            // Arrange
            var romanNumeral = new RomanNumeral();

            // Act
            var romanNumeralValue = romanNumeral.GetRomanValueFromArabicNum(4);

            // Assert
            Assert.AreEqual("IV", romanNumeralValue);
        }
        [TestMethod]
        public void RomanNumeral_GetNumber5FromArabic()
        {
            // Arrange
            var romanNumeral = new RomanNumeral();

            // Act
            var romanNumeralValue = romanNumeral.GetRomanValueFromArabicNum(5);

            // Assert
            Assert.AreEqual("V", romanNumeralValue);
        }

        [TestMethod]
        public void RomanNumeral_GetNumber2FromArabic()
        {
            // Arrange
            var romanNumeral = new RomanNumeral();

            // Act
            var romanNumeralValue = romanNumeral.GetRomanValueFromArabicNum(2);

            // Assert
            Assert.AreEqual("II", romanNumeralValue);
        }

        [TestMethod]
        public void RomanNumeral_GetNumber6FromArabic()
        {
            // Arrange
            var romanNumeral = new RomanNumeral();

            // Act
            var romanNumeralValue = romanNumeral.GetRomanValueFromArabicNum(6);

            // Assert
            Assert.AreEqual("VI", romanNumeralValue);
        }

        [TestMethod]
        public void RomanNumeral_GetLast()
        {
            // Arrange
            var romanNumeral = new RomanNumeral();

            // Act
            var romanNumeralValue = romanNumeral.GetRomanValueFromArabicNum(3999);

            // Assert
            Assert.AreEqual("MMMCMXCIX", romanNumeralValue);
        }
    }
}
