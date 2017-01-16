using System.Globalization;

namespace PrtgSharp.ChannelProperties.Optional.FirstRun
{
    /// <summary>
    /// Define a lower error limit for the channel. If enabled, the sensor will be set to a "Down" 
    /// status if this value is undercut and the LimitMode is activated. Note: Please provide the 
    /// limit value in the unit of the base data type, just as used in the <Value/> element of this 
    /// section. While a sensor shows a "Down" status triggered by a limit, it will still receive 
    /// data in its channels. The values defined with this element will be considered only on the 
    /// first sensor scan, when the channel is newly created; they are ignored on all further sensor 
    /// scans (and may be omitted). You can change this initial setting later in the Channel settings 
    /// of the sensor.
    /// </summary>
    public class LimitMinErrorOnFirstRunProperty : ChannelProperty
    {
        public LimitMinErrorOnFirstRunProperty(int upperErrorLimit)
            : base("limitminerror", upperErrorLimit.ToString(CultureInfo.InvariantCulture)) { }
    }
}