using NUnit.Framework;

namespace CodeWars.Tests
{
    public class Tests
    {
        [Test]
        public void Test()
        {
            // Arrange
            int input = 10;
            int expectedOutput = 23;

            // Act
            int actualOutput = Kata.Solution(input);

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
            AreTheySame areTheySame = new AreTheySame();

            // Act
            bool result = areTheySame.comp(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}