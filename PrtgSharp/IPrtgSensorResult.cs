using System.Xml.Linq;

namespace PrtgSharp
{
    public interface IPrtgSensorResult
    {
        XElement SerializeToXElement();
        SensorText Text { get; }
    }
}