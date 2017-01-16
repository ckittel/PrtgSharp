using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using PrtgSharp.ChannelProperties;
using PrtgSharp.ChannelProperties.Optional;
using PrtgSharp.ChannelProperties.Required;

namespace PrtgSharp
{
    /// <summary>
    /// This represents a <result></result> node in the final sensor
    /// </summary>
    public class Channel : IChannel
    {
        private readonly ChannelName _name;
        private readonly ChannelValue _value;

        public IEnumerable<ChannelProperty> Properties { get; }

        public string Name => _name.Value;

        public string Value => _value.Value;

        private Channel(string name, IEnumerable<ChannelProperty> properties)
        {
            _name = new ChannelName(name);
            Properties = properties;
        }

        public Channel(string name, int value)
            : this(name, value, null) { }

        public Channel(string name, int value, IEnumerable<ChannelProperty> properties)
            : this(name, AppendDataType(properties, ValueDataTypeProperty.Integer))
        {
            _value = ChannelValue.From(value);
        }

        public Channel(string name, float value)
            : this(name, value, null) { }

        public Channel(string name, float value, IEnumerable<ChannelProperty> properties)
            : this(name, AppendDataType(properties, ValueDataTypeProperty.Float))
        {
            _value = ChannelValue.From(value);
        }

        private static IEnumerable<ChannelProperty> AppendDataType(IEnumerable<ChannelProperty> source, ValueDataTypeProperty dataTypeProperty)
        {
            return source?.Concat(new[] { dataTypeProperty });
        }

        public XElement ToResultElement()
        {
            return new XElement("result", _name.ToXElement(), 
                _value.ToXElement(),
                Properties?.Select(p => p.ToXElement()));
        }
    }
}