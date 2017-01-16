using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties.Optional;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class NotifyChangedPropertyTests : ChannelPropertyTestsBase
    {
        [TestMethod]
        public void Should_Be_NotifyChanged_EmptyString()
        {
            // Act
            var channelProp = new NotifyChangedProperty();

            // Assert
            AssertChannelProp(channelProp, "notifychanged", string.Empty);
        }
    }
}