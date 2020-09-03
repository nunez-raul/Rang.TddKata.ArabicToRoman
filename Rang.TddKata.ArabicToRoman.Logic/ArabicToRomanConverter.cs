using System.Collections.Generic;
using System.Text;

namespace Rang.TddKata.ArabicToRoman.Logic
{
    public class ArabicToRomanConverter
    {
        //[10, 9, 5, 4, 1]
        //[X, IX, V, IV, I]
        private readonly Dictionary<int, string> valueSymbolMap = new Dictionary<int, string>
        {
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };

        public string Convert(int number)
        {
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
