using System.CodeDom;
using System.Collections.Generic;
using System.Xml.Linq;
using PrtgSharp.ChannelProperties;

namespace PrtgSharp
{
    public class PrtgSensorErrorResult : IPrtgSensorResult
    {
        public SensorText Text { get; }

        public PrtgSensorErrorResult(string sensorErrorMessage)
        {
            Text = new SensorText(sensorErrorMessage);
        }

        public XElement SerializeToXElement()
        {
            return new XElement("prtg",
                Text?.ToXElement(),
                new SensorError().ToXElement());
        }
    }
}