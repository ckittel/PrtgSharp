using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrtgSharp.Tests
{
    [TestClass]
    public class SensorTextTests
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
            var messageAtMax = string.Concat(Enumerable.Repeat("x", 2000));

            // Act
            var txt = new SensorText(messageAtMax);

            // Assert
            txt.Message.Should().EndWith("x").And.HaveLength(2000);
        }

        [TestMethod]
        public void When_Message_Is_Over_Max_Length_Then_Message_Should_Be_Truncated_With_Elipsis()
        {
            // Arrange
            var messageMoreThanMax = string.Concat(Enumerable.Repeat("x", 2001));

            // Act
            var txt = new SensorText(messageMoreThanMax);

            // Assert
            txt.Message.Should().EndWith("x…").And.HaveLength(2000);
        }

        [TestMethod]
        public void Serializes_Message_To_Text_Element()
        {
            // Arrange
            var txt = new SensorText("This is my sensor message.");

            // Act
            var element = txt.ToXElement();

            // Assert
            element.Name.LocalName.Should().Be("text");
            element.Value.Should().Be("This is my sensor message.");
        }

        [TestMethod]
        public void Serializes_Message_Needing_Ecoding_To_Text_Element()
        {
            // Arrange
            var txt = new SensorText("This is my <sensor> & message.");

            // Act
            var element = txt.ToXElement();

            // Assert
            element.Name.LocalName.Should().Be("text");
            element.Value.Should().Be("This is my <sensor> & message.");
            element.ToString().Should().Be("<text>This is my &lt;sensor&gt; &amp; message.</text>");
        }

        [TestMethod]
        public void Serializes_Too_Long_Message_To_Text_Element()
        {
            // Arrange
            var txt = new SensorText(string.Concat(Enumerable.Repeat("x", 2001)));

            // Act
            var element = txt.ToXElement();

            // Assert
            element.Name.LocalName.Should().Be("text");
            element.Value.Should().Be(string.Concat(Enumerable.Repeat("x", 1999)) + "…");
        }

        [TestMethod]
        public void Serializes_Null_Message_To_Null_Element()
        {
            // Arrange
            var txt = new SensorText(null);

            // Act
            var element = txt.ToXElement();

            // Assert
            element.Should().BeNull();
        }

        [TestMethod]
        public void Serializes_Empty_Message_To_Null_Element()
        {
            // Arrange
            var txt = new SensorText(string.Empty);

            // Act
            var element = txt.ToXElement();

            // Assert
            element.Should().BeNull();
        }

        [TestMethod]
        public void Serializes_Whitespace_Message_To_Matching_Element()
        {
            // Arrange
            var txt = new SensorText("  ");

            // Act
            var element = txt.ToXElement();

            // Assert
            element.Name.LocalName.Should().Be("text");
            element.Value.Should().Be("  ");
        }
    }
}
