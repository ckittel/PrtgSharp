namespace PrtgSharp.ChannelProperties
{
    public static class SpeedValueDisplayTimeProperty
    {
        public static ChannelProperty Second => SpeedTime("Second");
        public static ChannelProperty Minute => SpeedTime("Minute");
        public static ChannelProperty Hour => SpeedTime("Hour");
        public static ChannelProperty Day => SpeedTime("Day");

        private static ChannelProperty SpeedTime(string value) => new ChannelProperty("speedtime", value);
    }
}