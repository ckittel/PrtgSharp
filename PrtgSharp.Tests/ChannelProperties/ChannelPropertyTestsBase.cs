using System.Xml.Linq;
using FluentAssertions;
using PrtgSharp.ChannelProperties;

namespace PrtgSharp.Tests.ChannelProperties
{
    public abstract class ChannelPropertyTestsBase
    {
        protected static void AssertChannelProp(ChannelProperty channelProp, string name, string value)
        {
            channelProp.Name.Should().Be(name);
            channelProp.Value.Should().Be(value);
            channelProp.ToXElement().ToString(SaveOptions.DisableFormatting).Should().Be($"<{name}>{value}</{name}>");
        }
    }
}