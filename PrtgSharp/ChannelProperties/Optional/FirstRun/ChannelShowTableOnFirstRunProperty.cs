namespace PrtgSharp.ChannelProperties.Optional.FirstRun
{
    /// <summary>
    /// Init value for the Show in Table option. Default is 1 (yes). Note: The values defined with this element will be considered only on the first sensor scan, when the channel is newly created; they are ignored on all further sensor scans (and may be omitted). You can change this initial setting later in the Channel settings of the sensor.
    /// </summary>
    public static class ChannelShowTableOnFirstRunProperty
    {
        public static ChannelProperty No => ShowTable("0");
        public static ChannelProperty Yes => ShowTable("1");

        private static ChannelProperty ShowTable(string value) => new ChannelProperty("showtable", value);
    }
}