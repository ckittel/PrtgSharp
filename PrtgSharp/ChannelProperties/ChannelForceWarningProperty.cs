namespace PrtgSharp.ChannelProperties
{
    /// <summary>
    /// 	If enabled for at least one channel, the entire sensor is set to warning status. Default is 0 (no).
    /// </summary>
    public static class ChannelForceWarningProperty
    {
        public static ChannelProperty Yes => new ChannelProperty("warning", "1");
    }
}