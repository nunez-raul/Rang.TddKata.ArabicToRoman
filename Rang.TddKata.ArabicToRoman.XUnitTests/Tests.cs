using Rang.TddKata.ArabicToRoman.Logic;
using Xunit;

namespace Rang.TddKata.ArabicToRoman.XUnitTests
{
    public class Tests
    {
        [Fact]
        public void Convert1ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(1);

            // assert
            Assert.True(result == "I");
        }

        [Fact]
        public void Convert2ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(2);

            // assert
            Assert.True(result == "II");
        }

        [Fact]
        public void Convert3ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(3);

            // assert
            Assert.True(result == "III");
        }
    }
}
