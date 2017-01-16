namespace PrtgSharp.ChannelProperties
{
    /// <summary>
    /// 	Size used for the display value. E.g. if you have a value of 50000 and use Kilo as size the display is 50 kilo #. Default is One (value used as returned). For the Bytes and Speed units this is overridden by the setting in the user interface.
    /// </summary>
    public static class VolumeValueDisplaySize
    {
        public static ChannelProperty One => SpeedSize("One");
        public static ChannelProperty Kilo => SpeedSize("Kilo");
        public static ChannelProperty Mega => SpeedSize("Mega");
        public static ChannelProperty Giga => SpeedSize("Giga");
        public static ChannelProperty Tera => SpeedSize("Tera");
        public static ChannelProperty Byte => SpeedSize("Byte");
        public static ChannelProperty KiloByte => SpeedSize("KiloByte");
        public static ChannelProperty MegaByte => SpeedSize("MegaByte");
        public static ChannelProperty GigaByte => SpeedSize("GigaByte");
        public static ChannelProperty TeraByte => SpeedSize("TeraByte");
        public static ChannelProperty Bit => SpeedSize("Bit");
        public static ChannelProperty KiloBit => SpeedSize("KiloBit");
        public static ChannelProperty MegaBit => SpeedSize("MegaBit");
        public static ChannelProperty GigaBit => SpeedSize("GigaBit");
        public static ChannelProperty TeraBit => SpeedSize("TeraBit");

        private static ChannelProperty SpeedSize(string value) => new ChannelProperty("volumesize", value);
    }
}