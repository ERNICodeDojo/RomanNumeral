using System.Collections.Generic;
using System.Linq;

namespace JSRomanNumerals
{
    public class RomanConverter
    {
        private List<string[]> decimalConvertTable;
        private Dictionary<int, string> base10Combination;
        private const string unitChar = "I";
        private const string fiveChar = "V";
        private const string tenChar = "X";

        public RomanConverter()
        {
            decimalConvertTable = new List<string[]> {
                new string[] { "I", "V", "X" }, // 1 units
                new string[] { "X", "L", "C" }, // 10 units
                new string[] { "C", "D", "M" }, // 100 units
                new string[] { "M", "", "" },   // 1000 units
            };
            base10Combination = new Dictionary<int, string>();
            base10Combination.Add(0, "");
            base10Combination.Add(1, "I");
            base10Combination.Add(2, "II");
            base10Combination.Add(3, "III");
            base10Combination.Add(4, "IV");
            base10Combination.Add(5, "V");
            base10Combination.Add(6, "VI");
            base10Combination.Add(7, "VII");
            base10Combination.Add(8, "VIII");
            base10Combination.Add(9, "IX");
        }

        public string Convert(int number)
        {
            return number.ToString().Reverse().ToList()
                .Select((character, index) => ReplaceBase10Unit(index, character))
                .Aggregate((aggregateNumber, romanBase10Digit) => romanBase10Digit + aggregateNumber);
        }

        private string ReplaceBase10Unit(int decimalBasePosition, char decimalShiftUnit)
        {
            var convertBase10UnitRow = decimalConvertTable[decimalBasePosition];
            return base10Combination[int.Parse(decimalShiftUnit.ToString())]
                .Replace(tenChar, convertBase10UnitRow[2])
                .Replace(fiveChar, convertBase10UnitRow[1])
                .Replace(unitChar, convertBase10UnitRow[0]);
        }
    }
}
