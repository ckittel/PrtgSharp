using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;
using PrtgSharp.ChannelProperties.Optional.FirstRun;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class ChannelShowTableOnFirstRunPropertyTests : ChannelPropertyTestsBase
    {
        private static void AssertChannelProp(ChannelProperty channelProp, string value)
        {
            AssertChannelProp(channelProp, "showtable", value);
        }

        [TestMethod]
        public void Yes_Should_Be_ShowTable_1()
        {
            // Act
            var channelProp = ChannelShowTableOnFirstRunProperty.Yes;

            // Assert
            AssertChannelProp(channelProp, "1");
        }

        [TestMethod]
        public void Yes_Should_Be_ShowTable_0()
        {
            // Act
            var channelProp = ChannelShowTableOnFirstRunProperty.No;

            // Assert
            AssertChannelProp(channelProp, "0");
        }
    }
}