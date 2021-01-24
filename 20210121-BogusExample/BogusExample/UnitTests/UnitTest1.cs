using System;
using System.Net.Http;
using System.Threading.Tasks;
using NSubstitute;
using Xunit;
//using Microsoft.AspNetCore.Http;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            // Arrange
            var client = new HttpClient();

            // Act
            var result = await client.GetAsync("https://www.wikipedia.org/");

            Console.WriteLine(result.StatusCode);

            var content = result.Content;

            Console.WriteLine(content);

            // Assert
            Assert.True(true);

        }
    }
}
