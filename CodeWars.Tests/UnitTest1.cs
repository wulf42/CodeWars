using NUnit.Framework;
using System.Numerics;

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

        [Test]
        [TestCase("4", "1", 4)]
        [TestCase("4", "2", 6)]
        [TestCase("9", "7", 9)]
        [TestCase("9", "0", 1)]
        [TestCase("10", "1000000", 0)]
        public void GetLastDigit_Given2Numbers_ReturnLastDigitFromN1PowerN2(string n1, string n2, int expectedOutput)
        {
            // Arrange
            BigInteger a = BigInteger.Parse(n1);
            BigInteger b = BigInteger.Parse(n2);

            // Act
            int actualOutput = (int)Kata.GetLastDigit(a, b);
            // Assert
            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void JosephusPermutation_GivenList_ReturnListWithPermutation()
        {
            //Arrange
            List<object> items = new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<object> expectedOutput = new List<object> { 2, 4, 6, 8, 10, 3, 7, 1, 9, 5 };
            // Act
            List<object> actual = Kata.JosephusPermutation(items, 2);
            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }

        [Test]
        [TestCase("aabb", 2)]
        [TestCase("aab", 1)]
        [TestCase("112233", 3)]
        [TestCase("ccc", 1)]
        public void DuplicateCount_GivenString_ReturnsCountOfDuplicateChars(string input, int expectedOutput)
        {
            //Arrange
            // Act
            int actual = Kata.DuplicateCount(input);
            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void FindNeedle_GivenStringArray_ReturnPositionOfNeedleString()
        {
            //Arrange
            object[] input = new object[] { "hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk" };
            string expectedOutput = "found the needle at position 5";
            // Act
            string actual = Kata.FindNeedle(input);
            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }
    }
}