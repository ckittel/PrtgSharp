using System.Xml.Linq;
using PrtgSharp.Utilities;

namespace PrtgSharp
{
    /// <summary>
    /// Text the sensor returns in the Message field with every scanning interval. There can be one message per sensor, regardless of the number of channels.
    /// Default is "OK." Note: This element has to be provided outside of the <result> element.
    /// </summary>
    public class SensorText
    {
        private const int MaxMessageLength = 2000;

        public string Message { get; }

        public SensorText(string message)
        {
            Message = message.TruncateWithEllipsis(MaxMessageLength);
        }

        public XElement ToXElement()
        {
            if (string.IsNullOrEmpty(Message))
            {
                return null;
            }
            return new XElement("text", Message);
        } 
    }
}