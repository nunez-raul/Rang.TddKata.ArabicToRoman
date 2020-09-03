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

        [Fact]
        public void Convert10ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(10);

            // assert
            Assert.True(result == "X");
        }

        [Fact]
        public void Convert11ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(11);

            // assert
            Assert.True(result == "XI");
        }

        [Fact]
        public void Convert12ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(12);

            // assert
            Assert.True(result == "XII");
        }

        [Fact]
        public void Convert14ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(14);

            // assert
            Assert.True(result == "XIV");
        }

        [Fact]
        public void Convert15ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(15);

            // assert
            Assert.True(result == "XV");
        }

        [Fact]
        public void Convert20ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(20);

            // assert
            Assert.True(result == "XX");
        }

        [Fact]
        public void Convert40ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(40);

            // assert
            Assert.True(result == "XL");
        }

        [Fact]
        public void Convert49ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(49);

            // assert
            Assert.True(result == "XLIX");
        }

        [Fact]
        public void Convert50ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(50);

            // assert
            Assert.True(result == "L");
        }

        [Fact]
        public void Convert90ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(90);

            // assert
            Assert.True(result == "XC");
        }

        [Fact]
        public void Convert100ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(100);

            // assert
            Assert.True(result == "C");
        }

        [Fact]
        public void Convert400ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(400);

            // assert
            Assert.True(result == "CD");
        }

        [Fact]
        public void Convert500ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(500);

            // assert
            Assert.True(result == "D");
        }

        [Fact]
        public void Convert900ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(900);

            // assert
            Assert.True(result == "CM");
        }

        [Fact]
        public void Convert1000ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(1000);

            // assert
            Assert.True(result == "M");
        }

        [Fact]
        public void Convert4999ToRoman()
        {
            // arrange
            var arabicToRomanConverter = new ArabicToRomanConverter();

            // act
            var result = arabicToRomanConverter.Convert(4999);

            // assert
            Assert.True(result == "MMMMCMXCIX");
        }
    }
}
