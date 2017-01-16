using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using FluentAssertions;

namespace PrtgSharp.Tests
{
    [TestClass()]
    public class PrtgSensorSuccessResultTests
    {
        [TestMethod()]
        public void MessageOnly_Serializes()
        {
            // Arrange
            var result = new PrtgSensorSuccessResult("sensor message");

            // Act
            var serializedResult = result.Serialize();

            // Assert
            serializedResult.ToString(SaveOptions.DisableFormatting).Should().Be("<prtg><text>sensor message</text></prtg>");
        }

        [TestMethod()]
        public void NullMessage_Serializes()
        {
            // Arrange
            var result = new PrtgSensorSuccessResult((string)null);

            // Act
            var serializedResult = result.Serialize();

            // Assert
            serializedResult.ToString(SaveOptions.DisableFormatting).Should().Be("<prtg />");
        }

        [TestMethod()]
        public void EmptyMessage_Serializes()
        {
            // Arrange
            var result = new PrtgSensorSuccessResult(string.Empty);

            // Act
            var serializedResult = result.Serialize();

            // Assert
            serializedResult.ToString(SaveOptions.DisableFormatting).Should().Be("<prtg />");
        }

        [TestMethod()]
        public void ChannelOnly_Serializes()
        {
            // Arrange
            var sensor = new Channel("chan", 40);
            var result = new PrtgSensorSuccessResult(new [] {sensor});

            // Act
            var serializedResult = result.Serialize();

            // Assert
            serializedResult.ToString(SaveOptions.DisableFormatting).Should().Be("<prtg><result><channel>chan</channel><value>40</value></result></prtg>");
        }

        [TestMethod()]
        public void Message_And_Channel_Serializes()
        {
            // Arrange
            var sensor = new Channel("chan", 40);
            var result = new PrtgSensorSuccessResult("sensor message", new[] { sensor });

            // Act
            var serializedResult = result.Serialize();

            // Assert
            serializedResult.ToString(SaveOptions.DisableFormatting).Should().Be("<prtg><text>sensor message</text><result><channel>chan</channel><value>40</value></result></prtg>");
        }

        [TestMethod()]
        public void MultipleChannels_Serializes()
        {
            // Arrange
            var sensors = new List<Channel> {new Channel("chan0", 10), new Channel("chan1", 20)};
            var result = new PrtgSensorSuccessResult("sensor message", sensors );

            // Act
            var serializedResult = result.Serialize();

            // Assert
            serializedResult.ToString(SaveOptions.DisableFormatting).Should().Be("<prtg><text>sensor message</text><result><channel>chan0</channel><value>10</value></result><result><channel>chan1</channel><value>20</value></result></prtg>");
        }

        [TestMethod()]
        public void Message_And_NullChannel_Serializes()
        {
            // Arrange
            var result = new PrtgSensorSuccessResult("sensor message", null);

            // Act
            var serializedResult = result.Serialize();

            // Assert
            serializedResult.ToString(SaveOptions.DisableFormatting).Should().Be("<prtg><text>sensor message</text></prtg>");
        }

        [TestMethod()]
        public void NullMessage_And_NullChannel_Serializes()
        {
            // Arrange
            var result = new PrtgSensorSuccessResult(null, null);

            // Act
            var serializedResult = result.Serialize();

            // Assert
            serializedResult.ToString(SaveOptions.DisableFormatting).Should().Be("<prtg />");
        }
    }
}