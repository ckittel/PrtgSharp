using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;
using System;
using System.Xml.Linq;
using FluentAssertions;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass()]
    public class ChannelPropertyTests
    {
        [TestMethod()]
        public void HappyPath_PropChecks()
        {
            // Arrange
            var prop = new ChannelProperty("nAmE", "vAlUe");

            // Act / Assert
            prop.Name.Should().Be("nAmE");
            prop.Value.Should().Be("vAlUe");
        }

        [TestMethod()]
        public void BlankValue_PropChecks()
        {
            // Arrange
            var prop = new ChannelProperty("nAmE", string.Empty);

            // Act / Assert
            prop.Name.Should().Be("nAmE");
            prop.Value.Should().BeEmpty();
        }

        [TestMethod()]
        public void HappyPath_Seralizes()
        {
            // Arrange
            var prop = new ChannelProperty("nAmE", "vAlUe");

            // Act
            var result = prop.ToXElement();

            // Assert
            result.ToString(SaveOptions.DisableFormatting).Should().Be("<nAmE>vAlUe</nAmE>");
        }

        [TestMethod()]
        public void EmptyName_ThrowsException()
        {
            // Arrange
            Action act = () => new ChannelProperty(string.Empty, "value");

            // Act / Assert
            act.ShouldThrow<ArgumentException>();
        }

        [TestMethod()]
        public void NullName_ThrowsException()
        {
            // Arrange
            Action act = () => new ChannelProperty(null, "value");

            // Act / Assert
            act.ShouldThrow<ArgumentNullException>();
        }

        [TestMethod()]
        public void NullValue_ThrowsException()
        {
            // Arrange
            Action act = () => new ChannelProperty("name", null);

            // Act / Assert
            act.ShouldThrow<ArgumentNullException>();
        }

        [TestMethod()]
        public void ValueEmpty_Seralizes()
        {
            // Arrange
            var prop = new ChannelProperty("name", string.Empty);

            // Act
            var result = prop.ToXElement();

            // Assert
            result.ToString(SaveOptions.DisableFormatting).Should().Be("<name></name>");
        }

        [TestMethod()]
        public void ValueWithXmlChars_Seralizes()
        {
            // Arrange
            var prop = new ChannelProperty("prop", "why<would>you&do this?");

            // Act
            var result = prop.ToXElement();

            // Assert
            result.ToString(SaveOptions.DisableFormatting).Should().Be("<prop>why&lt;would&gt;you&amp;do this?</prop>");
        }
    }
}