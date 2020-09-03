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

        [Fact]
        public void Convert4ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(4);

            // assert
            Assert.True(result == "IV");
        }

        [Fact]
        public void Convert5ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(5);

            // assert
            Assert.True(result == "V");
        }

        [Fact]
        public void Convert6ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(6);

            // assert
            Assert.True(result == "VI");
        }

        [Fact]
        public void Convert7ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(7);

            // assert
            Assert.True(result == "VII");
        }

        [Fact]
        public void Convert8ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(8);

            // assert
            Assert.True(result == "VIII");
        }

        [Fact]
        public void Convert9ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(9);

            // assert
            Assert.True(result == "IX");
        }
    }
}
