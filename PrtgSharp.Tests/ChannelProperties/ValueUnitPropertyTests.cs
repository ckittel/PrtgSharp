using System.Xml.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class ValueUnitPropertyTests
    {
        private static void AssertChannelProp(ChannelProperty channelProp, string value)
        {
            channelProp.Name.Should().Be("unit");
            channelProp.Value.Should().Be(value);
            channelProp.ToXElement().ToString(SaveOptions.DisableFormatting).Should().Be($"<unit>{value}</unit>");
        }

        [TestMethod]
        public void BytesBandwidth_Should_Be_Unit_BytesBandwidth()
        {
            // Act
            var channelProp = ValueUnitProperty.BytesBandwidth;

            // Assert
            AssertChannelProp(channelProp, "BytesBandwidth");
        }
        
        [TestMethod]
        public void BytesMemory_Should_Be_Unit_BytesMemory()
        {
            // Act
            var channelProp = ValueUnitProperty.BytesMemory;

            // Assert
            AssertChannelProp(channelProp, "BytesMemory");
        }


        [TestMethod]
        public void BytesDisk_Should_Be_Unit_BytesDisk()
        {
            // Act
            var channelProp = ValueUnitProperty.BytesDisk;

            // Assert
            AssertChannelProp(channelProp, "BytesDisk");
        }


        [TestMethod]
        public void Temperature_Should_Be_Unit_Temperature()
        {
            // Act
            var channelProp = ValueUnitProperty.Temperature;

            // Assert
            AssertChannelProp(channelProp, "Temperature");
        }


        [TestMethod]
        public void Percent_Should_Be_Unit_Percent()
        {
            // Act
            var channelProp = ValueUnitProperty.Percent;

            // Assert
            AssertChannelProp(channelProp, "Percent");
        }


        [TestMethod]
        public void TimeResponse_Should_Be_Unit_TimeResponse()
        {
            // Act
            var channelProp = ValueUnitProperty.TimeResponse;

            // Assert
            AssertChannelProp(channelProp, "TimeResponse");
        }


        [TestMethod]
        public void TimeSeconds_Should_Be_Unit_TimeSeconds()
        {
            // Act
            var channelProp = ValueUnitProperty.TimeSeconds;

            // Assert
            AssertChannelProp(channelProp, "TimeSeconds");
        }


        [TestMethod]
        public void Custom_Should_Be_Unit_Custom()
        {
            // Act
            var channelProp = ValueUnitProperty.Custom;

            // Assert
            AssertChannelProp(channelProp, "Custom");
        }


        [TestMethod]
        public void Count_Should_Be_Unit_Count()
        {
            // Act
            var channelProp = ValueUnitProperty.Count;

            // Assert
            AssertChannelProp(channelProp, "Count");
        }

        [TestMethod]
        public void Cpu_Should_Be_Unit_CPU()
        {
            // Act
            var channelProp = ValueUnitProperty.Cpu;

            // Assert
            AssertChannelProp(channelProp, "CPU");
        }


        [TestMethod]
        public void BytesFile_Should_Be_Unit_BytesFile()
        {
            // Act
            var channelProp = ValueUnitProperty.BytesFile;

            // Assert
            AssertChannelProp(channelProp, "BytesFile");
        }


        [TestMethod]
        public void SpeedDisk_Should_Be_Unit_SpeedDisk()
        {
            // Act
            var channelProp = ValueUnitProperty.SpeedDisk;

            // Assert
            AssertChannelProp(channelProp, "SpeedDisk");
        }


        [TestMethod]
        public void SpeedNet_Should_Be_Unit_SpeedNet()
        {
            // Act
            var channelProp = ValueUnitProperty.SpeedNet;

            // Assert
            AssertChannelProp(channelProp, "SpeedNet");
        }


        [TestMethod]
        public void TimeHours_Should_Be_Unit_TimeHours()
        {
            // Act
            var channelProp = ValueUnitProperty.TimeHours;

            // Assert
            AssertChannelProp(channelProp, "TimeHours");
        }
    }
}