using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;
using PrtgSharp.ChannelProperties.Optional;
using PrtgSharp.ChannelProperties.Optional.FirstRun;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class LimitWarningMessageOnFirstRunPropertyTests : ChannelPropertyTestsBase
    {
        private static void AssertChannelProp(ChannelProperty channelProp, string value)
        {
            AssertChannelProp(channelProp, "LimitWarningMsg", value);
        }

        [TestMethod]
        public void ProvidedMessage_Should_Be_LimitWarningMsg_Message()
        {
            // Act
            var channelProp = new LimitWarningMessageOnFirstRunProperty("Warning Message");

            // Assert
            AssertChannelProp(channelProp, "Warning Message");
        }

        [TestMethod]
        public void ProvidedMessage_At_Max_Length_Should_Be_LimitWarningMsg_Message()
        {
            // Arrange
            var message = string.Concat(Enumerable.Repeat("x", 256));

            // Act
            var channelProp = new LimitWarningMessageOnFirstRunProperty(message);

            // Assert
            AssertChannelProp(channelProp, string.Concat(Enumerable.Repeat("x", 256)));
        }

        [TestMethod]
        public void ProvidedMessage_Over_Max_Length_Should_Be_LimitWarningMsg_TruncatedMessage()
        {
            // Arrange
            var message = string.Concat(Enumerable.Repeat("x", 257));

            // Act
            var channelProp = new LimitWarningMessageOnFirstRunProperty(message);

            // Assert
            AssertChannelProp(channelProp, string.Concat(Enumerable.Repeat("x", 255)) + "…");
        }
    }
}