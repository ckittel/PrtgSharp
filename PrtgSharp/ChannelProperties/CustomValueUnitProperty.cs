using PrtgSharp.Utilities;

namespace PrtgSharp.ChannelProperties
{
    /// <summary>
    /// Optional: Only used when the ValueUnitProperty is Custom.  Limited to 8 chars.
    /// </summary>
    public class CustomValueUnitProperty : ChannelProperty
    {
        public CustomValueUnitProperty(string value) 
            : base("customunit", value.TruncateWithEllipsis(8)) { }
    }
}