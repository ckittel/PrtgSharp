using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class ValueDataTypePropertyTests : ChannelPropertyTestsBase
    {
        private static void AssertChannelProp(ChannelProperty channelProp, string value)
        {
            AssertChannelProp(channelProp, "float", value);
        }

        [TestMethod]
        public void Float_Should_Be_Float_1()
        {
            // Act
            var channelProp = ValueDataTypeProperty.Float;

            // Assert
            AssertChannelProp(channelProp, "1");
        }

        [TestMethod]
        public void Int_Should_Be_Float_0()
        {
            // Act
            var channelProp = ValueDataTypeProperty.Integer;

            // Assert
            AssertChannelProp(channelProp, "0");
        }
    }
}