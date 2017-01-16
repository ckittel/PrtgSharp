using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;
using PrtgSharp.ChannelProperties.Optional.FirstRun;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class LimitMinWarningOnFirstRunPropertyTests : ChannelPropertyTestsBase
    {
        private static void AssertChannelProp(ChannelProperty channelProp, string value)
        {
            AssertChannelProp(channelProp, "limitminwarning", value);
        }

        [TestMethod]
        public void ProvidedInt_Should_Be_LimitMinWarning_Value()
        {
            // Act
            var channelProp = new LimitMinWarningOnFirstRunProperty(42);

            // Assert
            AssertChannelProp(channelProp, "42");
        }

        [TestMethod]
        public void Zero_Should_Be_LimitMinWarning_0()
        {
            // Act
            var channelProp = new LimitMinWarningOnFirstRunProperty(0);

            // Assert
            AssertChannelProp(channelProp, "0");
        }

        [TestMethod]
        public void Negative_Should_Be_LimitMinWarning_Value()
        {
            // Act
            var channelProp = new LimitMinWarningOnFirstRunProperty(-42);

            // Assert
            AssertChannelProp(channelProp, "-42");
        }
    }
}