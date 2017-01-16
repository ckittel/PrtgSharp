using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties.Optional.FirstRun;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class ValueLookupOnFirstRunPropertyTests : ChannelPropertyTestsBase
    {
        [TestMethod]
        public void ProvidedLookupId_Should_Be_ValueLookup_LookupId()
        {
            // Act
            var channelProp = new ValueLookupOnFirstRunProperty("lookupId01");

            // Assert
            AssertChannelProp(channelProp, "valuelookup", "lookupId01");
        }

    }
}