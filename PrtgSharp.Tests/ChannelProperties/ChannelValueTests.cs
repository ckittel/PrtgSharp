using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;
using PrtgSharp.ChannelProperties.Required;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class ChannelValueTests : ChannelPropertyTestsBase
    {
        private static void AssertChannelProp(ChannelProperty channelProp, string value)
        {
            AssertChannelProp(channelProp, "value", value);
        }

        [TestMethod]
        public void FromNegativeInt_Should_BeStringVersion_OfValue()
        {
            // Act
            var channelProp = ChannelValue.From(-5);

            // Assert
            AssertChannelProp(channelProp, (-5).ToString(CultureInfo.InvariantCulture));
        }

        [TestMethod]
        public void FromZeroInt_Should_Be_0()
        {
            // Act
            var channelProp = ChannelValue.From(0);

            // Assert
            AssertChannelProp(channelProp, "0");
        }


        [TestMethod]
        public void FromPosInt_Should_Be_ThatValue()
        {
            // Act
            var channelProp = ChannelValue.From(42);

            // Assert
            AssertChannelProp(channelProp, "42");
        }

        [TestMethod]
        public void FromNegativeFloat_Should_BeStringVersion_OfValue()
        {
            // Act
            var channelProp = ChannelValue.From(-5.5f);

            // Assert
            AssertChannelProp(channelProp, (-5.5f).ToString(CultureInfo.InvariantCulture));
        }

        [TestMethod]
        public void FromZeroFloat_Should_Be_0()
        {
            // Act
            var channelProp = ChannelValue.From(0f);

            // Assert
            AssertChannelProp(channelProp, "0");
        }


        [TestMethod]
        public void FromPosFloat_Should_Be_ThatValue()
        {
            // Act
            var channelProp = ChannelValue.From(42.24f);

            // Assert
            AssertChannelProp(channelProp, "42.24");
        }

        [TestMethod]
        public void ManyPrecisionFloat_Should_Have_FiveDecimals()
        {
            // Act
            var channelProp = ChannelValue.From(42.2442244224422442f);

            // Assert
            AssertChannelProp(channelProp, "42.24422");
        }
    }
}