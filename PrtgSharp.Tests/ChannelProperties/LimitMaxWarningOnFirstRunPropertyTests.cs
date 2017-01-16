using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;
using PrtgSharp.ChannelProperties.Optional;
using PrtgSharp.ChannelProperties.Optional.FirstRun;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class LimitMaxWarningOnFirstRunPropertyTests : ChannelPropertyTestsBase
    {
        private static void AssertChannelProp(ChannelProperty channelProp, string value)
        {
            AssertChannelProp(channelProp, "LimitMaxWarning", value);
        }

        [TestMethod]
        public void ProvidedInt_Should_Be_LimitMaxWarning_Value()
        {
            // Act
            var channelProp = new LimitMaxWarningOnFirstRunProperty(42);

            // Assert
            AssertChannelProp(channelProp, "42");
        }

        [TestMethod]
        public void Zero_Should_Be_LimitMaxWarning_0()
        {
            // Act
            var channelProp = new LimitMaxWarningOnFirstRunProperty(0);

            // Assert
            AssertChannelProp(channelProp, "0");
        }

        [TestMethod]
        public void Negative_Should_Be_LimitMaxWarning_Value()
        {
            // Act
            var channelProp = new LimitMaxWarningOnFirstRunProperty(-42);

            // Assert
            AssertChannelProp(channelProp, "-42");
        }
    }
}