namespace PrtgSharp.ChannelProperties.Optional.FirstRun
{
    public class ValueLookupOnFirstRunProperty : ChannelProperty
    {
        public ValueLookupOnFirstRunProperty(string lookupFileId)
            : base("valuelookup", lookupFileId) { }
    }
}