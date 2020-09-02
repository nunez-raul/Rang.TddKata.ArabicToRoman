using System.Text;

namespace Rang.TddKata.ArabicToRoman.Logic
{
    public class ArabicToRomanConverter
    {
        public string Convert(int number)
        {
            if (number == 5)
                return "V";

            if (number == 4)
                return "IV";

            var sb = new StringBuilder();
            for(int i = 0; i < number; i++)
            {
                sb.Append("I");
            }
            
            return sb.ToString();
        }
    }
}
