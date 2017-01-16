using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;
using PrtgSharp.ChannelProperties.Optional;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class SpeedValueDisplaySizePropertyTests : ChannelPropertyTestsBase
    {

        private static void AssertChannelProp(ChannelProperty channelProp, string value)
        {
            AssertChannelProp(channelProp, "speedsize", value);
        }

        [TestMethod]
        public void One_Should_Be_SpeedSize_One()
        {
            // Act
            var channelProp = SpeedValueDisplaySizeProperty.One;

            // Assert
            AssertChannelProp(channelProp, "One");
        }

        [TestMethod]
        public void Kilo_Should_Be_SpeedSize_Kilo()
        {
            // Act
            var channelProp = SpeedValueDisplaySizeProperty.Kilo;

            // Assert
            AssertChannelProp(channelProp, "Kilo");
        }

        [TestMethod]
        public void Mega_Should_Be_SpeedSize_Mega()
        {
            // Act
            var channelProp = SpeedValueDisplaySizeProperty.Mega;

            // Assert
            AssertChannelProp(channelProp, "Mega");
        }

        [TestMethod]
        public void Giga_Should_Be_SpeedSize_Giga()
        {
            // Act
            var channelProp = SpeedValueDisplaySizeProperty.Giga;

            // Assert
            AssertChannelProp(channelProp, "Giga");
        }

        [TestMethod]
        public void Tera_Should_Be_SpeedSize_Tera()
        {
            // Act
            var channelProp = SpeedValueDisplaySizeProperty.Tera;

            // Assert
            AssertChannelProp(channelProp, "Tera");
        }

        [TestMethod]
        public void Byte_Should_Be_SpeedSize_Byte()
        {
            // Act
            var channelProp = SpeedValueDisplaySizeProperty.Byte;

            // Assert
            AssertChannelProp(channelProp, "Byte");
        }

        [TestMethod]
        public void KiloByte_Should_Be_SpeedSize_KiloByte()
        {
            // Act
            var channelProp = SpeedValueDisplaySizeProperty.Kilobyte;

            // Assert
            AssertChannelProp(channelProp, "KiloByte");
        }

        [TestMethod]
        public void MegaByte_Should_Be_SpeedSize_MegaByte()
        {
            // Act
            var channelProp = SpeedValueDisplaySizeProperty.Megabyte;

            // Assert
            AssertChannelProp(channelProp, "MegaByte");
        }

        [TestMethod]
        public void GigaByte_Should_Be_SpeedSize_GigaByte()
        {
            // Act
            var channelProp = SpeedValueDisplaySizeProperty.Gigabyte;

            // Assert
            AssertChannelProp(channelProp, "GigaByte");
        }

        [TestMethod]
        public void TeraByte_Should_Be_SpeedSize_TeraByte()
        {
            // Act
            var channelProp = SpeedValueDisplaySizeProperty.Terabyte;

            // Assert
            AssertChannelProp(channelProp, "TeraByte");
        }

        [TestMethod]
        public void Bit_Should_Be_SpeedSize_Bit()
        {
            // Act
            var channelProp = SpeedValueDisplaySizeProperty.Bit;

            // Assert
            AssertChannelProp(channelProp, "Bit");
        }

        [TestMethod]
        public void KiloBit_Should_Be_SpeedSize_KiloBit()
        {
            // Act
            var channelProp = SpeedValueDisplaySizeProperty.Kilobit;

            // Assert
            AssertChannelProp(channelProp, "KiloBit");
        }

        [TestMethod]
        public void MegaBit_Should_Be_SpeedSize_MegaBit()
        {
            // Act
            var channelProp = SpeedValueDisplaySizeProperty.Megabit;

            // Assert
            AssertChannelProp(channelProp, "MegaBit");
        }

        [TestMethod]
        public void GigaBit_Should_Be_SpeedSize_GigaBit()
        {
            // Act
            var channelProp = SpeedValueDisplaySizeProperty.Gigabit;

            // Assert
            AssertChannelProp(channelProp, "GigaBit");
        }

        [TestMethod]
        public void TeraBit_Should_Be_SpeedSize_TeraBit()
        {
            // Act
            var channelProp = SpeedValueDisplaySizeProperty.Terabit;

            // Assert
            AssertChannelProp(channelProp, "TeraBit");
        }
    }
}