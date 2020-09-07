using System.Collections.Generic;
using System.Text;

namespace Rang.TddKata.ArabicToRoman.Logic
{
    public class ArabicToRomanConverter
    {
        public const string MaxLimitExceededMessage = "Out of limits; peek a smaller number.";
        //[10, 9, 5, 4, 1]
        //[X, IX, V, IV, I]
        private readonly Dictionary<int, string> valueSymbolMap = new Dictionary<int, string>
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };

        public string Convert(int number)
        {
            if (number > 3999)
                return MaxLimitExceededMessage;

            var sb = new StringBuilder();

            foreach (var key in valueSymbolMap.Keys)
            {
                if (number == key)
                    return valueSymbolMap[key];

                if (number > key)
                    return sb.Append(valueSymbolMap[key]).Append(Convert(number - key)).ToString();
            }

            return "";
        }
    }
}
