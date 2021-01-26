using System;
using Xunit;
using StringListDictArrayNmspc;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Act
            //var actual = ;
            string nullString = null;
            string actual = String.Empty;

            //
            Assert.Throws<NullReferenceException>(() => actual = Program.Transform(nullString) );
        }

        [Theory]
        [InlineData("Hello world","helloworld")]
        [InlineData("","")]
        public void Test2(string input, string expected)
        {
            // Arrange
            // Act
            var actual = Program.Transform(input);

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}
