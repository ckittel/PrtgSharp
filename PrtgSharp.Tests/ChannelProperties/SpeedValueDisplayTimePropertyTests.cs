using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;
using PrtgSharp.ChannelProperties.Optional;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class SpeedValueDisplayTimePropertyTests : ChannelPropertyTestsBase
    {

        private static void AssertChannelProp(ChannelProperty channelProp, string value)
        {
            AssertChannelProp(channelProp, "speedtime", value);
        }

        [TestMethod]
        public void Second_Should_Be_SpeedTime_Second()
        {
            // Act
            var channelProp = SpeedValueDisplayTimeProperty.Second;

            // Assert
            AssertChannelProp(channelProp, "Second");
        }

        [TestMethod]
        public void Minute_Should_Be_SpeedTime_Minute()
        {
            // Act
            var channelProp = SpeedValueDisplayTimeProperty.Minute;

            // Assert
            AssertChannelProp(channelProp, "Minute");
        }

        [TestMethod]
        public void Hour_Should_Be_SpeedTime_Hour()
        {
            // Act
            var channelProp = SpeedValueDisplayTimeProperty.Hour;

            // Assert
            AssertChannelProp(channelProp, "Hour");
        }

        [TestMethod]
        public void Day_Should_Be_SpeedTime_Day()
        {
            // Act
            var channelProp = SpeedValueDisplayTimeProperty.Day;

            // Assert
            AssertChannelProp(channelProp, "Day");
        }
    }
}