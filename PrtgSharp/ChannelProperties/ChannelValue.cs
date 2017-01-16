using System.Globalization;

namespace PrtgSharp.ChannelProperties
{
    /// <summary>
    /// This represents <result>...<value>Value</value>...</result>
    /// </summary>
    internal class ChannelValue : ChannelProperty
    {
        private ChannelValue(string value)
            : base("value", value) { }

        public static ChannelValue From(float value)
        {
            return new ChannelValue(value.ToString(CultureInfo.InvariantCulture));
        }

        public static ChannelValue From(int value)
        {
            return new ChannelValue(value.ToString(CultureInfo.InvariantCulture));
        }
    }
}