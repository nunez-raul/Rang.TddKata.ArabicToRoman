using Rang.TddKata.ArabicToRoman.Logic;
using Xunit;

namespace Rang.TddKata.ArabicToRoman.XUnitTests
{
    public class Tests
    {
        [Fact]
        public void Test1_Convert1ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(1);

            // assert
            Assert.True(result == "I");
        }
    }
}
