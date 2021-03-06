﻿namespace PrtgSharp.ChannelProperties.Required
{
    /// <summary>
    /// This represents <result><channel>Value</channel>...</result>
    /// </summary>
    internal class ChannelName : ChannelProperty
    {
        public ChannelName(string name)
            : base("channel", name) { }
    }
}
