using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;
using PrtgSharp.ChannelProperties.Optional;
using PrtgSharp.ChannelProperties.Optional.FirstRun;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class LimitModeOnFirstRunPropertyTests : ChannelPropertyTestsBase
    {
        private static void AssertChannelProp(ChannelProperty channelProp, string value)
        {
            AssertChannelProp(channelProp, "limitmode", value);
        }

        [TestMethod]
        public void Active_Should_Be_LimitMode_1()
        {
            // Act
            var channelProp = LimitModeOnFirstRunProperty.Active;

            // Assert
            AssertChannelProp(channelProp, "1");
        }

        [TestMethod]
        public void Inactive_Should_Be_LimitMode_0()
        {
            // Act
            var channelProp = LimitModeOnFirstRunProperty.Inactive;

            // Assert
            AssertChannelProp(channelProp, "0");
        }
    }
}