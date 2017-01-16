namespace PrtgSharp.ChannelProperties
{
    public static class ValueUnitProperty
    {
        public static ChannelProperty BytesBandwidth => Unit("BytesBandwidth");
        public static ChannelProperty BytesMemory => Unit("BytesMemory");
        public static ChannelProperty BytesDisk => Unit("BytesDisk");
        public static ChannelProperty Temperature => Unit("Temperature");
        public static ChannelProperty Percent => Unit("Percent");
        public static ChannelProperty TimeResponse => Unit("TimeResponse");
        public static ChannelProperty TimeSeconds => Unit("TimeSeconds");
        public static ChannelProperty Custom => Unit("Custom");
        public static ChannelProperty Count => Unit("Count");
        public static ChannelProperty Cpu => Unit("CPU");
        public static ChannelProperty BytesFile => Unit("BytesFile");
        public static ChannelProperty SpeedDisk => Unit("SpeedDisk");
        public static ChannelProperty SpeedNet => Unit("SpeedNet");
        public static ChannelProperty TimeHours => Unit("TimeHours");

        private static ChannelProperty Unit(string value) => new ChannelProperty("unit", value);
    }
}