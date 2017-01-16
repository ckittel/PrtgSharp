using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;
using System;
using System.Xml.Linq;
using FluentAssertions;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class ChannelPropertyTests : ChannelPropertyTestsBase
    {
        [TestMethod]
        public void HappyPath()
        {
            // Arrange
            var prop = new ChannelProperty("nAmE", "vAlUe");

            // Act / Assert
            AssertChannelProp(prop, "nAmE", "vAlUe");
        }

        [TestMethod]
        public void BlankValue()
        {
            // Arrange
            var prop = new ChannelProperty("nAmE", string.Empty);

            // Act / Assert
            AssertChannelProp(prop, "nAmE", string.Empty);
        }

        [TestMethod]
        public void EmptyName_ThrowsException()
        {
            // Arrange
            Action act = () => new ChannelProperty(string.Empty, "value");

            // Act / Assert
            act.ShouldThrow<ArgumentException>();
        }

        [TestMethod]
        public void NullName_ThrowsException()
        {
            // Arrange
            Action act = () => new ChannelProperty(null, "value");

            // Act / Assert
            act.ShouldThrow<ArgumentNullException>();
        }

        [TestMethod]
        public void NullValue_ThrowsException()
        {
            // Arrange
            Action act = () => new ChannelProperty("name", null);

            // Act / Assert
            act.ShouldThrow<ArgumentNullException>();
        }

        [TestMethod]
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