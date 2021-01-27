using System;
using Xunit;
using Pangram;

namespace XUnitTestProjectFinalExam
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("The quick brown fox jumps over the lazy dog.", true)]
        [InlineData("a", false)]
        [InlineData("",false)]
        public void Test_Pangram_Original_StandardCases(string input, bool expected)
        {
            // Act
            var result = Program.Pangram(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("The quick brown fox jumps over the lazy dog.", true)]
        [InlineData("a", false)]
        [InlineData("", false)]
        public void Test_Pangram_Alternative2_StandardCases(string input2, bool expected2)
        {
            // Act
            var result = Program.PangramAlternative2(input2);

            // Assert
            Assert.Equal(expected2, result);
        }

        [Theory]
        [InlineData("The quick brown fox jumps over the lazy dog.5;", true)]
        [InlineData("a", false)]
        [InlineData("", false)]
        public void Test_Pangram_Alternative3_StandardCases(string input, bool expected2)
        {
            // Act
            var result = Program.PangramAlternative3(input);

            // Assert
            Assert.Equal(expected2, result);
        }
    }
}
