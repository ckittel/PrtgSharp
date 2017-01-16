using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;
using PrtgSharp.ChannelProperties.Optional.FirstRun;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class LimitErrorMessageOnFirstRunPropertyTests : ChannelPropertyTestsBase
    {
        private static void AssertChannelProp(ChannelProperty channelProp, string value)
        {
            AssertChannelProp(channelProp, "limiterrormsg", value);
        }

        [TestMethod]
        public void ProvidedMessage_Should_Be_LimitErrorMsg_Message()
        {
            // Act
            var channelProp = new LimitErrorMessageOnFirstRunProperty("Error Message");

            // Assert
            AssertChannelProp(channelProp, "Error Message");
        }

        [TestMethod]
        public void ProvidedMessage_At_Max_Length_Should_Be_LimitErrorMsg_Message()
        {
            // Arrange
            var message = string.Concat(Enumerable.Repeat("x", 256));

            // Act
            var channelProp = new LimitErrorMessageOnFirstRunProperty(message);

            // Assert
            AssertChannelProp(channelProp, string.Concat(Enumerable.Repeat("x", 256)));
        }

        [TestMethod]
        public void ProvidedMessage_Over_Max_Length_Should_Be_LimitErrorMsg_TruncatedMessage()
        {
            // Arrange
            var message = string.Concat(Enumerable.Repeat("x", 257));

            // Act
            var channelProp = new LimitErrorMessageOnFirstRunProperty(message);

            // Assert
            AssertChannelProp(channelProp, string.Concat(Enumerable.Repeat("x", 255)) + "…");
        }
    }
}