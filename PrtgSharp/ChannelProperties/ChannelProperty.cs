using System.Xml.Linq;
using PrtgSharp.Utilities;

namespace PrtgSharp.ChannelProperties
{
    /// <summary>
    /// Represents one of many valid elements inside of a <result></result> element.
    /// </summary>
    public class ChannelProperty
    {
        public string Name { get; }
        public string Value { get; }

        public ChannelProperty(string name, string value)
        {
            Check.NotEmpty(name, nameof(name));
            Check.NotNull(value, nameof(value));

            Name = name;
            Value = value;
        }

        public XElement ToXElement()
        {
            // <Name>Value</Name>
            return new XElement(Name, Value);
        } 
    }
}