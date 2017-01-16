using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class ValueModePropertyTests : ChannelPropertyTestsBase
    {
        private static void AssertChannelProp(ChannelProperty channelProp, string value)
        {
            AssertChannelProp(channelProp, "mode", value);
        }

        [TestMethod]
        public void Absolute_Should_Be_Mode_Absolute()
        {
            // Act
            var channelProp = ValueModeProperty.Absolute;

            // Assert
            AssertChannelProp(channelProp, "Absolute");
        }

        [TestMethod]
        public void Difference_Should_Be_Mode_Difference()
        {
            // Act
            var channelProp = ValueModeProperty.Difference;

            // Assert
            AssertChannelProp(channelProp, "Difference");
        }
    }
}