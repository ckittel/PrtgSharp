using System.Xml.Linq;

namespace PrtgSharp
{
    public interface IPrtgSensorResult
    {
        SensorText Text { get; }
        XElement SerializeToXElement();
    }
}