using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using FluentAssertions;

namespace PrtgSharp.Tests
{
    [TestClass]
    public class PrtgSensorSuccessResultTests
    {
        [TestMethod]
        public void MessageOnly_Serializes()
        {
            // Arrange
            var result = new PrtgSensorSuccessResult("sensor message");

            // Act
            var serializedResult = result.SerializeToXElement().ToString(SaveOptions.DisableFormatting);

            // Assert
            serializedResult.Should().Be("<prtg><text>sensor message</text></prtg>");
        }

        [TestMethod]
        public void NullMessage_Serializes()
        {
            // Arrange
            var result = new PrtgSensorSuccessResult((string)null);

            // Act
            var serializedResult = result.SerializeToXElement();

            // Assert
            serializedResult.ToString(SaveOptions.DisableFormatting).Should().Be("<prtg />");
        }

        [TestMethod]
        public void EmptyMessage_Serializes()
        {
            // Arrange
            var result = new PrtgSensorSuccessResult(string.Empty);

            // Act
            var serializedResult = result.SerializeToXElement().ToString(SaveOptions.DisableFormatting);

            // Assert
            serializedResult.Should().Be("<prtg />");
        }

        [TestMethod]
        public void ChannelOnly_Serializes()
        {
            // Arrange
            var channel = new Channel("chan", 40);
            var result = new PrtgSensorSuccessResult(new [] { channel });

            // Act
            var serializedResult = result.SerializeToXElement().ToString(SaveOptions.DisableFormatting);

            // Assert
            serializedResult.Should().Be("<prtg><result><channel>chan</channel><value>40</value></result></prtg>");
        }

        [TestMethod]
        public void Message_And_Channel_Serializes()
        {
            // Arrange
            var channel = new Channel("chan", 40);
            var result = new PrtgSensorSuccessResult("sensor message", new[] { channel });

            // Act
            var serializedResult = result.SerializeToXElement().ToString(SaveOptions.DisableFormatting);

            // Assert
            serializedResult.Should().Be("<prtg><text>sensor message</text><result><channel>chan</channel><value>40</value></result></prtg>");
        }

        [TestMethod]
        public void MultipleChannels_Serializes()
        {
            // Arrange
            var channels = new List<Channel> {new Channel("chan0", 10), new Channel("chan1", 20)};
            var result = new PrtgSensorSuccessResult("sensor message", channels);

            // Act
            var serializedResult = result.SerializeToXElement().ToString(SaveOptions.DisableFormatting);

            // Assert
            serializedResult.Should().Be("<prtg><text>sensor message</text><result><channel>chan0</channel><value>10</value></result><result><channel>chan1</channel><value>20</value></result></prtg>");
        }

        [TestMethod]
        public void Message_And_NullChannel_Serializes()
        {
            // Arrange
            var result = new PrtgSensorSuccessResult("sensor message", null);

            // Act
            var serializedResult = result.SerializeToXElement().ToString(SaveOptions.DisableFormatting);

            // Assert
            serializedResult.Should().Be("<prtg><text>sensor message</text></prtg>");
        }

        [TestMethod]
        public void NullMessage_And_NullChannel_Serializes()
        {
            // Arrange
            var result = new PrtgSensorSuccessResult(null, null);

            // Act
            var serializedResult = result.SerializeToXElement().ToString(SaveOptions.DisableFormatting);

            // Assert
            serializedResult.Should().Be("<prtg />");
        }

        [TestMethod]
        public void SuccessResult_Returned_When_At_50_Channels()
        {
            // Arrange
            var channels = new List<Channel>();
            for (int i = 0; i < 50; i++)
            {
                channels.Add(new Channel($"chan{i}", 0));
            }
            var result = new PrtgSensorSuccessResult(null, channels);

            // Act
            var serializedResult = result.SerializeToXElement().ToString(SaveOptions.DisableFormatting);

            // Assert
            serializedResult.Should().MatchRegex(@"<prtg>(<result><channel>chan\d{1,2}</channel><value>0</value></result>){50}</prtg>");
        }

        [TestMethod]
        public void ErrorResult_Returned_When_Over_50_Channels()
        {
            // Arrange
            var channels = new List<Channel>();
            for (int i = 0; i < 51; i++)
            {
                channels.Add(new Channel($"chan{i}", 0));
            }
            var result = new PrtgSensorSuccessResult("won't see me", channels);

            // Act
            var serializedResult = result.SerializeToXElement().ToString(SaveOptions.DisableFormatting); ;

            // Assert
            serializedResult.Should().Be("<prtg><text>Cannot have more than 50 channels defined for a sensor; this sensor has 51.</text><error>1</error></prtg>");
        }

        [TestMethod]
        public void ErrorResult_Returned_When_There_Are_Duplicate_Channels()
        {
            // Arrange
            var channels = new List<Channel> {new Channel("A", 0), new Channel("A", 0)};
            var result = new PrtgSensorSuccessResult("won't see me", channels);

            // Act
            var serializedResult = result.SerializeToXElement().ToString(SaveOptions.DisableFormatting); ;

            // Assert
            serializedResult.Should().Be("<prtg><text>One or more channels were included multiple times in this sensor.  Duplicate channels: A</text><error>1</error></prtg>");
        }

        [TestMethod]
        public void ErrorResult_Returned_When_There_Are_Duplicate_Channels_Only_Lists_Duplicates_Once()
        {
            // Arrange
            var channels = new List<Channel> {
                new Channel("Not A Dup", 0),
                new Channel("A", 0),
                new Channel("A", 0),
                new Channel("B", 0),
                new Channel("B", 0),
                new Channel("Also Not A Dup", 0),
            };
            var result = new PrtgSensorSuccessResult("won't see me", channels);

            // Act
            var serializedResult = result.SerializeToXElement().ToString(SaveOptions.DisableFormatting); ;

            // Assert
            serializedResult.Should().Be("<prtg><text>One or more channels were included multiple times in this sensor.  Duplicate channels: A, B</text><error>1</error></prtg>");
        }

        [TestMethod]
        public void ErrorResult_Returned_When_There_Are_Duplicate_Channels_Case_Insenstive()
        {
            // Arrange
            var channels = new List<Channel> {
                new Channel("A", 0),
                new Channel("a", 0),
                new Channel("B", 0),
                new Channel("b", 0),
            };
            var result = new PrtgSensorSuccessResult("won't see me", channels);

            // Act
            var serializedResult = result.SerializeToXElement().ToString(SaveOptions.DisableFormatting); ;

            // Assert
            serializedResult.Should().MatchRegex("<prtg><text>One or more channels were included multiple times in this sensor.  Duplicate channels: [Aa], [Bb]</text><error>1</error></prtg>");
        }
    }
}