using System.Xml.Linq;

namespace PrtgSharp
{
    public class SensorError
    {
        public XElement ToXElement()
        {
            return new XElement("error", "1");
        }
    }
}