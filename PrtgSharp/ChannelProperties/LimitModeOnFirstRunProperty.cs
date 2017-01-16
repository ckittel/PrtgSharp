namespace PrtgSharp.ChannelProperties
{
    /// <summary>
    /// Define if the limit settings defined above will be active. Default is 0 (no; limits inactive). If 0 is used the limits will be written to the sensor channel settings as predefined values, but limits will be disabled. Note: This setting will be considered only on the first sensor scan, when the channel is newly created; it is ignored on all further sensor scans (and may be omitted). You can change this initial setting later in the Channel settings of the sensor.
    /// </summary>
    public static class LimitModeOnFirstRunProperty
    {
        public static ChannelProperty Active => Mode("1");
        public static ChannelProperty Inactive => Mode("0");

        private static ChannelProperty Mode(string value) => new ChannelProperty("limitmode", value);
    }
}