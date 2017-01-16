using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrtgSharp.Tests
{
    [TestClass]
    public class TextTests
    {
        [TestMethod]
        public void When_Message_Is_Under_Max_Length_Then_Message_Should_Be_What_Was_Passed_In()
        {
            // Arrange
            var messageLessThanMax = string.Concat(Enumerable.Repeat("x", 1999));

            // Act
            var txt = new SensorText(messageLessThanMax);

            // Assert
            txt.Message.Should().EndWith("x").And.HaveLength(1999);
        }

        [TestMethod]
        public void When_Message_Is_Max_Length_Then_Message_Should_Be_What_Was_Passed_In()
        {
            // Arrange
            var messageLessThanMax = string.Concat(Enumerable.Repeat("x", 2000));

            // Act
            var txt = new SensorText(messageLessThanMax);

            // Assert
            txt.Message.Should().EndWith("x").And.HaveLength(2000);
        }

        [TestMethod]
        public void When_Message_Is_Over_Max_Length_Then_Message_Should_Be_Truncated_With_Elipsis()
        {
            // Arrange
            var messageLessThanMax = string.Concat(Enumerable.Repeat("x", 2001));

            // Act
            var txt = new SensorText(messageLessThanMax);

            // Assert
            txt.Message.Should().EndWith("x…").And.HaveLength(2000);
        }
    }
}
