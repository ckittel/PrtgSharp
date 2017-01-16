using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;
using PrtgSharp.ChannelProperties.Optional;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class VolumeValueDisplaySizePropertyTests : ChannelPropertyTestsBase
    {

        private static void AssertChannelProp(ChannelProperty channelProp, string value)
        {
            AssertChannelProp(channelProp, "volumesize", value);
        }

        [TestMethod]
        public void One_Should_Be_VolumeSize_One()
        {
            // Act
            var channelProp = VolumeValueDisplaySizeProperty.One;

            // Assert
            AssertChannelProp(channelProp, "One");
        }

        [TestMethod]
        public void Kilo_Should_Be_VolumeSize_Kilo()
        {
            // Act
            var channelProp = VolumeValueDisplaySizeProperty.Kilo;

            // Assert
            AssertChannelProp(channelProp, "Kilo");
        }

        [TestMethod]
        public void Mega_Should_Be_VolumeSize_Mega()
        {
            // Act
            var channelProp = VolumeValueDisplaySizeProperty.Mega;

            // Assert
            AssertChannelProp(channelProp, "Mega");
        }

        [TestMethod]
        public void Giga_Should_Be_VolumeSize_Giga()
        {
            // Act
            var channelProp = VolumeValueDisplaySizeProperty.Giga;

            // Assert
            AssertChannelProp(channelProp, "Giga");
        }

        [TestMethod]
        public void Tera_Should_Be_VolumeSize_Tera()
        {
            // Act
            var channelProp = VolumeValueDisplaySizeProperty.Tera;

            // Assert
            AssertChannelProp(channelProp, "Tera");
        }

        [TestMethod]
        public void Byte_Should_Be_VolumeSize_Byte()
        {
            // Act
            var channelProp = VolumeValueDisplaySizeProperty.Byte;

            // Assert
            AssertChannelProp(channelProp, "Byte");
        }

        [TestMethod]
        public void KiloByte_Should_Be_VolumeSize_KiloByte()
        {
            // Act
            var channelProp = VolumeValueDisplaySizeProperty.Kilobyte;

            // Assert
            AssertChannelProp(channelProp, "KiloByte");
        }

        [TestMethod]
        public void MegaByte_Should_Be_VolumeSize_MegaByte()
        {
            // Act
            var channelProp = VolumeValueDisplaySizeProperty.Megabyte;

            // Assert
            AssertChannelProp(channelProp, "MegaByte");
        }

        [TestMethod]
        public void GigaByte_Should_Be_VolumeSize_GigaByte()
        {
            // Act
            var channelProp = VolumeValueDisplaySizeProperty.Gigabyte;

            // Assert
            AssertChannelProp(channelProp, "GigaByte");
        }

        [TestMethod]
        public void TeraByte_Should_Be_VolumeSize_TeraByte()
        {
            // Act
            var channelProp = VolumeValueDisplaySizeProperty.Terabyte;

            // Assert
            AssertChannelProp(channelProp, "TeraByte");
        }

        [TestMethod]
        public void Bit_Should_Be_VolumeSize_Bit()
        {
            // Act
            var channelProp = VolumeValueDisplaySizeProperty.Bit;

            // Assert
            AssertChannelProp(channelProp, "Bit");
        }

        [TestMethod]
        public void KiloBit_Should_Be_VolumeSize_KiloBit()
        {
            // Act
            var channelProp = VolumeValueDisplaySizeProperty.Kilobit;

            // Assert
            AssertChannelProp(channelProp, "KiloBit");
        }

        [TestMethod]
        public void MegaBit_Should_Be_VolumeSize_MegaBit()
        {
            // Act
            var channelProp = VolumeValueDisplaySizeProperty.Megabit;

            // Assert
            AssertChannelProp(channelProp, "MegaBit");
        }

        [TestMethod]
        public void GigaBit_Should_Be_VolumeSize_GigaBit()
        {
            // Act
            var channelProp = VolumeValueDisplaySizeProperty.Gigabit;

            // Assert
            AssertChannelProp(channelProp, "GigaBit");
        }

        [TestMethod]
        public void TeraBit_Should_Be_VolumeSize_TeraBit()
        {
            // Act
            var channelProp = VolumeValueDisplaySizeProperty.Terabit;

            // Assert
            AssertChannelProp(channelProp, "TeraBit");
        }
    }
}