using System.Xml.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrtgSharp.Tests
{
    [TestClass]
    public class PrtgSensorErrorResultTests
    {
        [TestMethod]
        public void Message_Serializes()
        {
            // Arrange
            var result = new PrtgSensorErrorResult("error sensor message");

            // Act
            var serilalizedResult = result.SerializeToXElement().ToString(SaveOptions.DisableFormatting);

            // Assert
            serilalizedResult.Should().Be("<prtg><text>error sensor message</text><error>1</error></prtg>");
        }

        [TestMethod]
        public void Null_Message_Serializes()
        {
            // Arrange
            var result = new PrtgSensorErrorResult(null);

            // Act
            var serilalizedResult = result.SerializeToXElement().ToString(SaveOptions.DisableFormatting);

            // Assert
            serilalizedResult.Should().Be("<prtg><error>1</error></prtg>");
        }

        [TestMethod]
        public void Empty_Message_Serializes()
        {
            // Arrange
            var result = new PrtgSensorErrorResult(string.Empty);

            // Act
            var serilalizedResult = result.SerializeToXElement().ToString(SaveOptions.DisableFormatting);

            // Assert
            serilalizedResult.Should().Be("<prtg><error>1</error></prtg>");
        }
    }
}