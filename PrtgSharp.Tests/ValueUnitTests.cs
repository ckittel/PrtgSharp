using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;

namespace PrtgSharp.Tests
{
    [TestClass]
    public class ValueUnitTests
    {
        [TestMethod]
        public void BytesBandwidth_Should_Be_Unit_BytesBandwidth()
        {
            // Act
            var channelProp = ValueUnitProperty.BytesBandwidth;

            // Assert
            channelProp.Name.Should().Be("unit");
            channelProp.Value.Should().Be("BytesBandwidth");
        }
        
        [TestMethod]
        public void BytesMemory_Should_Be_Unit_BytesMemory()
        {
            // Act
            var channelProp = ValueUnitProperty.BytesMemory;

            // Assert
            channelProp.Name.Should().Be("unit");
            channelProp.Value.Should().Be("BytesMemory");
        }


        [TestMethod]
        public void BytesDisk_Should_Be_Unit_BytesDisk()
        {
            // Act
            var channelProp = ValueUnitProperty.BytesDisk;

            // Assert
            channelProp.Name.Should().Be("unit");
            channelProp.Value.Should().Be("BytesDisk");
        }


        [TestMethod]
        public void Temperature_Should_Be_Unit_Temperature()
        {
            // Act
            var channelProp = ValueUnitProperty.Temperature;

            // Assert
            channelProp.Name.Should().Be("unit");
            channelProp.Value.Should().Be("Temperature");
        }


        [TestMethod]
        public void Percent_Should_Be_Unit_Percent()
        {
            // Act
            var channelProp = ValueUnitProperty.Percent;

            // Assert
            channelProp.Name.Should().Be("unit");
            channelProp.Value.Should().Be("Percent");
        }


        [TestMethod]
        public void TimeResponse_Should_Be_Unit_TimeResponse()
        {
            // Act
            var channelProp = ValueUnitProperty.TimeResponse;

            // Assert
            channelProp.Name.Should().Be("unit");
            channelProp.Value.Should().Be("TimeResponse");
        }


        [TestMethod]
        public void TimeSeconds_Should_Be_Unit_TimeSeconds()
        {
            // Act
            var channelProp = ValueUnitProperty.TimeSeconds;

            // Assert
            channelProp.Name.Should().Be("unit");
            channelProp.Value.Should().Be("TimeSeconds");
        }


        [TestMethod]
        public void Custom_Should_Be_Unit_Custom()
        {
            // Act
            var channelProp = ValueUnitProperty.Custom;

            // Assert
            channelProp.Name.Should().Be("unit");
            channelProp.Value.Should().Be("Custom");
        }


        [TestMethod]
        public void Count_Should_Be_Unit_Count()
        {
            // Act
            var channelProp = ValueUnitProperty.Count;

            // Assert
            channelProp.Name.Should().Be("unit");
            channelProp.Value.Should().Be("Count");
        }

        [TestMethod]
        public void Cpu_Should_Be_Unit_CPU()
        {
            // Act
            var channelProp = ValueUnitProperty.Cpu;

            // Assert
            channelProp.Name.Should().Be("unit");
            channelProp.Value.Should().Be("CPU");
        }


        [TestMethod]
        public void BytesFile_Should_Be_Unit_BytesFile()
        {
            // Act
            var channelProp = ValueUnitProperty.BytesFile;

            // Assert
            channelProp.Name.Should().Be("unit");
            channelProp.Value.Should().Be("BytesFile");
        }


        [TestMethod]
        public void SpeedDisk_Should_Be_Unit_SpeedDisk()
        {
            // Act
            var channelProp = ValueUnitProperty.SpeedDisk;

            // Assert
            channelProp.Name.Should().Be("unit");
            channelProp.Value.Should().Be("SpeedDisk");
        }


        [TestMethod]
        public void SpeedNet_Should_Be_Unit_SpeedNet()
        {
            // Act
            var channelProp = ValueUnitProperty.SpeedNet;

            // Assert
            channelProp.Name.Should().Be("unit");
            channelProp.Value.Should().Be("SpeedNet");
        }


        [TestMethod]
        public void TimeHours_Should_Be_Unit_TimeHours()
        {
            // Act
            var channelProp = ValueUnitProperty.TimeHours;

            // Assert
            channelProp.Name.Should().Be("unit");
            channelProp.Value.Should().Be("TimeHours");
        }
    }
}