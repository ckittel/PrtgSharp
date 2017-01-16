using System.Xml.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.Tests.ChannelProperties;

namespace PrtgSharp.Tests
{
    [TestClass]
    public class SensorErrorTests : ChannelPropertyTestsBase
    {
        [TestMethod]
        public void Yes_Should_Be_Error_1()
        {
            // Act
            var error = new SensorError();

            // Assert
            error.ToXElement().ToString(SaveOptions.DisableFormatting).Should().Be("<error>1</error>");
        }
    }
}