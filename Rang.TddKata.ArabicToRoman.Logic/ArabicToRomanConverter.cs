using System.Text;

namespace Rang.TddKata.ArabicToRoman.Logic
{
    public class ArabicToRomanConverter
    {
        public string Convert(int number)
        {
            var sb = new StringBuilder();

            if (number >= 5)
                return sb.Append("V").Append(Convert(number - 5)).ToString();

            if (number == 4)
                return "IV";

            for(int i = 0; i < number; i++)
            {
                sb.Append("I");
            }
            
            return sb.ToString();
        }
    }
}
