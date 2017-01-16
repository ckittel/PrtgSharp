namespace PrtgSharp.ChannelProperties
{
    /// <summary>
    /// Default value for the Show in Graph option. Default is 1 (yes). 
    /// Note: The values defined with this element will be considered only on the first 
    /// sensor scan, when the channel is newly created; they are ignored on all further 
    /// sensor scans (and may be omitted). You can change this initial setting later in 
    /// the Channel settings of the sensor.
    /// </summary>
    public static class ChannelShowChartOnFirstRunProperty
    {
        public static ChannelProperty No => ShowChart("0");
        public static ChannelProperty Yes => ShowChart("1");

        private static ChannelProperty ShowChart(string value) => new ChannelProperty("showchart", value);
    }
}