using System.Collections.Generic;
using System.Xml.Linq;
using PrtgSharp.ChannelProperties;

namespace PrtgSharp
{
    public class PrtgSensorErrorResult : PrtgSensorResult
    {
        public PrtgSensorErrorResult(SensorText text)
            : base(text) { }

        public PrtgSensorErrorResult(string sensorErrorMessage)
            : this(new SensorText(sensorErrorMessage)) { }

        protected override IEnumerable<XElement> SerializeResult()
        {
            return new []{ SensorErrorProperty.Yes.ToXElement() };
        }
    }
}