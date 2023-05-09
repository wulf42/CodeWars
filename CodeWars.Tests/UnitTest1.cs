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
    }
}