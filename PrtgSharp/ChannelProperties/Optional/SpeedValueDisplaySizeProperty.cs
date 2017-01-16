namespace PrtgSharp.ChannelProperties.Optional
{
    /// <summary>
    /// 	Size used for the display value. E.g. if you have a value of 50000 and use Kilo as size the display is 50 kilo #. Default is One (value used as returned). For the Bytes and Speed units this is overridden by the setting in the user interface.
    /// </summary>
    public static class SpeedValueDisplaySizeProperty
    {
        public static ChannelProperty One => SpeedSize("One");
        public static ChannelProperty Kilo => SpeedSize("Kilo");
        public static ChannelProperty Mega => SpeedSize("Mega");
        public static ChannelProperty Giga => SpeedSize("Giga");
        public static ChannelProperty Tera => SpeedSize("Tera");
        public static ChannelProperty Byte => SpeedSize("Byte");
        public static ChannelProperty Kilobyte => SpeedSize("KiloByte");
        public static ChannelProperty Megabyte => SpeedSize("MegaByte");
        public static ChannelProperty Gigabyte => SpeedSize("GigaByte");
        public static ChannelProperty Terabyte => SpeedSize("TeraByte");
        public static ChannelProperty Bit => SpeedSize("Bit");
        public static ChannelProperty Kilobit => SpeedSize("KiloBit");
        public static ChannelProperty Megabit => SpeedSize("MegaBit");
        public static ChannelProperty Gigabit => SpeedSize("GigaBit");
        public static ChannelProperty Terabit => SpeedSize("TeraBit");

        private static ChannelProperty SpeedSize(string value) => new ChannelProperty("speedsize", value);
    }
}