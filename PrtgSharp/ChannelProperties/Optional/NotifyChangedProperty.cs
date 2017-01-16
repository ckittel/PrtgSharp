namespace PrtgSharp.ChannelProperties.Optional
{
    /// <summary>
    /// 	If a returned channel contains this tag, it will trigger a change notification that you can use with the Change Trigger to send a notification.
    /// </summary>
    public class NotifyChangedProperty : ChannelProperty
    {
        public NotifyChangedProperty() 
            : base("notifychanged", string.Empty) { }
    }
}