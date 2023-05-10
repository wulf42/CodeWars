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
            // Arrange
            Kata kata = new Kata();

            // Act
            int actualOutput = kata.sumOfNumbersDivisibleBy3or5(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
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
            // Arrange
            Kata kata = new Kata();

            // Act
            bool result = kata.comp(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("test", "grfg")]
        [TestCase("This is my first ROT13 excercise!", "Guvf vf zl svefg EBG13 rkprepvfr!")]
        public void Rot13_GivenString_ReturnsStringCodedWithRot13Algorithm(string input, string expectedOutput)
        {
            // Arrange
            Kata kata = new Kata();
            // Act
            string actualOutput = kata.Rot13(input);
            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}