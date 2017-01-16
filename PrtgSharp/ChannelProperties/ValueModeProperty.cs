namespace PrtgSharp.ChannelProperties
{
    /// <summary>
    /// Selects if the value is a absolute value or counter. Default is Absolute.
    /// </summary>
    public static class ValueModeProperty
    {
        public static ChannelProperty Absolute => Mode("Absolute");
        public static ChannelProperty Difference => Mode("Difference");

        private static ChannelProperty Mode(string value) => new ChannelProperty("mode", value);
    }
}