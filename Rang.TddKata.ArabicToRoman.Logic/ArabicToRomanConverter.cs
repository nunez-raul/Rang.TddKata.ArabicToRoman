namespace Rang.TddKata.ArabicToRoman.Logic
{
    public class ArabicToRomanConverter
    {
        public string Convert(int number)
        {
            if (number == 2)
                return "II";
            return "I";
        }
    }
}
