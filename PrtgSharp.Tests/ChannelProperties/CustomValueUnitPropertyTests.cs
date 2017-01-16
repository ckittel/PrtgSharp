using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;
using PrtgSharp.ChannelProperties.Optional;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class CustomValueUnitPropertyTests : ChannelPropertyTestsBase
    {
        private static void AssertChannelProp(ChannelProperty channelProp, string value)
        {
            AssertChannelProp(channelProp, "customunit", value);
        }

        [TestMethod]
        public void UnderMaxLengthValue_Should_Be_CustomUnit_Value()
        {
            // Act
            var channelProp = new CustomValueUnitProperty("Parsecs");

            // Assert
            AssertChannelProp(channelProp, "Parsecs");
        }

        [TestMethod]
        public void AtMaxLengthValue_Should_Be_CustomUnit_Value()
        {
            // Act
            var channelProp = new CustomValueUnitProperty("12345678");

            // Assert
            AssertChannelProp(channelProp, "12345678");
        }

        [TestMethod]
        public void OverMaxLengthValue_Should_Be_CustomUnit_ValueWithElipsis()
        {
            // Act
            var channelProp = new CustomValueUnitProperty("123456789");

            // Assert
            AssertChannelProp(channelProp, "1234567…");
        }
    }
}