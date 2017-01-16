using System.Collections.Generic;
using System.Xml.Linq;
using PrtgSharp.ChannelProperties;

namespace PrtgSharp
{
    public interface IChannel
    {
        string Name { get; }
        string Value { get; }
        IEnumerable<ChannelProperty> Properties { get; }
        XElement ToResultElement();
    }
}