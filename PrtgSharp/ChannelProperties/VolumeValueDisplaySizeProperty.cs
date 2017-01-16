namespace PrtgSharp.ChannelProperties
{
    /// <summary>
    /// 	Size used for the display value. E.g. if you have a value of 50000 and use Kilo as size the display is 50 kilo #. Default is One (value used as returned). For the Bytes and Speed units this is overridden by the setting in the user interface.
    /// </summary>
    public static class VolumeValueDisplaySizeProperty
    {
        public static ChannelProperty One => VolumeSize("One");
        public static ChannelProperty Kilo => VolumeSize("Kilo");
        public static ChannelProperty Mega => VolumeSize("Mega");
        public static ChannelProperty Giga => VolumeSize("Giga");
        public static ChannelProperty Tera => VolumeSize("Tera");
        public static ChannelProperty Byte => VolumeSize("Byte");
        public static ChannelProperty KiloByte => VolumeSize("KiloByte");
        public static ChannelProperty MegaByte => VolumeSize("MegaByte");
        public static ChannelProperty GigaByte => VolumeSize("GigaByte");
        public static ChannelProperty TeraByte => VolumeSize("TeraByte");
        public static ChannelProperty Bit => VolumeSize("Bit");
        public static ChannelProperty KiloBit => VolumeSize("KiloBit");
        public static ChannelProperty MegaBit => VolumeSize("MegaBit");
        public static ChannelProperty GigaBit => VolumeSize("GigaBit");
        public static ChannelProperty TeraBit => VolumeSize("TeraBit");

        private static ChannelProperty VolumeSize(string value) => new ChannelProperty("volumesize", value);
    }
}