using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;
using PrtgSharp.ChannelProperties.Optional;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class ChannelForceWarningPropertyTests : ChannelPropertyTestsBase
    {
        [TestMethod]
        public void Yes_Should_Be_Warning_1()
        {
            // Act
            var channelProp = ChannelForceWarningProperty.Yes;

            // Assert
            AssertChannelProp(channelProp, "warning", "1");
        }
    }
}