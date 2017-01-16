using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace PrtgSharp
{
    public class PrtgSensorSuccessResult : PrtgSensorResult
    {

        public PrtgSensorSuccessResult(SensorText text, IEnumerable<IChannel> channels)
            : base(text, channels) { }

        public PrtgSensorSuccessResult(IEnumerable<IChannel> channels)
            : this ((SensorText)null, channels) { }

        public PrtgSensorSuccessResult(string sensorMessage, IEnumerable<IChannel> channels)
            : this(new SensorText(sensorMessage), channels) { }

        public PrtgSensorSuccessResult(string sensorMessage)
            : this(sensorMessage, null) { }

        protected override IEnumerable<XElement> SerializeResult()
        {
            return Channels?.Select(r => r.ToResultElement());
        }
    }
}