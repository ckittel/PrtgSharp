namespace PrtgSharp.ChannelProperties.Optional
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
        public static ChannelProperty Kilobyte => VolumeSize("KiloByte");
        public static ChannelProperty Megabyte => VolumeSize("MegaByte");
        public static ChannelProperty Gigabyte => VolumeSize("GigaByte");
        public static ChannelProperty Terabyte => VolumeSize("TeraByte");
        public static ChannelProperty Bit => VolumeSize("Bit");
        public static ChannelProperty Kilobit => VolumeSize("KiloBit");
        public static ChannelProperty Megabit => VolumeSize("MegaBit");
        public static ChannelProperty Gigabit => VolumeSize("GigaBit");
        public static ChannelProperty Terabit => VolumeSize("TeraBit");

        private static ChannelProperty VolumeSize(string value) => new ChannelProperty("volumesize", value);
    }
}