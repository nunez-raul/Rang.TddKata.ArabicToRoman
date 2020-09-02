using System.Text;

namespace Rang.TddKata.ArabicToRoman.Logic
{
    public class ArabicToRomanConverter
    {
        public string Convert(int number)
        {
            var sb = new StringBuilder();

            for(int i = 0; i < number; i++)
            {
                sb.Append("I");
            }
            
            return sb.ToString();
        }
    }
}
