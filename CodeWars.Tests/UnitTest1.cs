using NUnit.Framework;

namespace CodeWars.Tests
{
    public class Tests
    {
        [Test]
        [TestCase(10, 23)]
        [TestCase(20, 78)]
        public void sumOfNumbersDivisibleBy3or5_GivenOneInt_ReturnsSumOfRightNumbers(int input, int expectedOutput)
        {
            // Act
            int actualOutput = Kata.sumOfNumbersDivisibleBy3or5(input);

            // Assert
            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }

        [Test]
        [TestCase(new int[] { 121, 144, 19, 161, 19, 144, 19, 11 },
           new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 },
           true)]
        [TestCase(new int[] { 121, 144, 19, 161, 19, 144, 19, 11 },
           new int[] { 132, 14641, 20736, 361, 25921, 361, 20736, 361 },
           false)]
        public void Comp_GivenTwoArrays_ReturnsTrueIfSquaredArrayBContainsTheSameElementsAsArrayA(int[] a, int[] b, bool expected)
        {
            // Act
            bool result = Kata.comp(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("test", "grfg")]
        [TestCase("This is my first ROT13 excercise!", "Guvf vf zl svefg EBG13 rkprepvfr!")]
        public void Rot13_GivenString_ReturnsStringCodedWithRot13Algorithm(string input, string expectedOutput)
        {
            // Act
            string actualOutput = Kata.Rot13(input);
            // Assert
            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }

        [Test]
        [TestCase(0, "00:00:00")]
        [TestCase(5, "00:00:05")]
        [TestCase(60, "00:01:00")]
        [TestCase(86399, "23:59:59")]
        [TestCase(359999, "99:59:59")]
        public void GetReadableTime_GivenInt_ReturnsConvertedTimeToDigitalClock(int seconds, string expectedOutput)
        {
            // Act
            string actualOutput = Kata.GetReadableTime(seconds);
            // Assert
            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }
    }
}