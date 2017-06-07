using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumeral
    {
        private Dictionary<int, string> baseNumbers;

        public RomanNumeral()
        {
            baseNumbers = new Dictionary<int, string>();
            baseNumbers.Add(1, "I");
            baseNumbers.Add(4, "IV");
            baseNumbers.Add(5, "V");
            baseNumbers.Add(9, "IX");
            baseNumbers.Add(10, "X");
            baseNumbers.Add(40, "XL");
            baseNumbers.Add(50, "L");
            baseNumbers.Add(90, "XC");
            baseNumbers.Add(100, "C");
            baseNumbers.Add(400, "CD");
            baseNumbers.Add(500, "D");
            baseNumbers.Add(900, "CM");
            baseNumbers.Add(1000, "M");
        }

        public string GetRomanValueFromArabicNum(int number)
        {
            var currentNumber = number;
            var ret = ""; 
            var keys = baseNumbers.AsEnumerable().Reverse().ToArray();
            var i = 0; 
            while (currentNumber > 0)
            {
                var item = keys[i];
                if(currentNumber >= item.Key)
                {
                    currentNumber -= item.Key;
                    ret += item.Value;
                }
                else
                {
                    i++;
                }
            }
            return ret; 
        }

        public string GetRomanValueFromArabicNumFirst(int number)
        {
            string  romanNumber;

            int previous = 0;
            int next = 0;
            foreach (var item in baseNumbers)
            {
                next = item.Key;
                if (item.Key == number)
                {
                    return item.Value;
                }

                if (number > item.Key)
                {
                    previous = item.Key;
                }
                else
                {
                    break;
                }
            }
            var diff = number - previous;
            if (diff < 3)
            {
                romanNumber = string.Join("", Enumerable.Repeat(baseNumbers[previous], number).ToArray());
            }
            else
            {
                romanNumber = baseNumbers[previous] + baseNumbers[next];
            }

            return romanNumber;
        }
    }
}
