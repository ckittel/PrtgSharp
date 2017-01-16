using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;
using PrtgSharp.ChannelProperties.Required;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class ChannelNameTests : ChannelPropertyTestsBase
    {
        [TestMethod]
        public void ProvidedValue_Should_Be_Channel_Value()
        {
            // Act
            var channelProp = new ChannelName("Channel Name");

            // Assert
            AssertChannelProp(channelProp, "channel", "Channel Name");
        }
    }
}