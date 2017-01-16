using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class LimitMaxErrorOnFirstRunPropertyTests : ChannelPropertyTestsBase
    {
        private static void AssertChannelProp(ChannelProperty channelProp, string value)
        {
            AssertChannelProp(channelProp, "LimitMaxError", value);
        }

        [TestMethod]
        public void ProvidedInt_Should_Be_LimitMaxError_Value()
        {
            // Act
            var channelProp = new LimitMaxErrorOnFirstRunProperty(42);

            // Assert
            AssertChannelProp(channelProp, "42");
        }

        [TestMethod]
        public void Zero_Should_Be_LimitMaxError_0()
        {
            // Act
            var channelProp = new LimitMaxErrorOnFirstRunProperty(0);

            // Assert
            AssertChannelProp(channelProp, "0");
        }

        [TestMethod]
        public void Negative_Should_Be_LimitMaxError_Value()
        {
            // Act
            var channelProp = new LimitMaxErrorOnFirstRunProperty(-42);

            // Assert
            AssertChannelProp(channelProp, "-42");
        }
    }
}