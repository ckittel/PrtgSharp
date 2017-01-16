using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

namespace PrtgSharp
{
    public class PrtgSensorSuccessResult : IPrtgSensorResult
    {
        public SensorText Text { get; }

        public IEnumerable<IChannel> Channels { get; }

        private const int MaxNumberOfChannels = 50;

        private PrtgSensorSuccessResult(SensorText text, IEnumerable<IChannel> channels)
        {
            Text = text;
            Channels = channels;
        }

        public PrtgSensorSuccessResult(IEnumerable<IChannel> channels)
            : this ((SensorText)null, channels) { }

        public PrtgSensorSuccessResult(string sensorMessage, IEnumerable<IChannel> channels)
            : this(new SensorText(sensorMessage), channels) { }

        public PrtgSensorSuccessResult(string sensorMessage)
            : this(sensorMessage, null) { }

        public XElement SerializeToXElement()
        {
            var errorResult = ValidateOrGetErrorResult();

            if (errorResult != null)
            {
                return errorResult.SerializeToXElement();
            }

            return new XElement("prtg",
                Text?.ToXElement(),
                Channels?.Select(r => r.ToXElement()));
        }

        private PrtgSensorErrorResult ValidateOrGetErrorResult()
        {
            if (Channels != null)
            {
                if (Channels.Count() > MaxNumberOfChannels)
                {
                    return new PrtgSensorErrorResult($"Cannot have more than {MaxNumberOfChannels} channels defined for a sensor; this sensor has {Channels.Count()}.");
                }

                var duplicates = GetDuplicateChannels();
                if (duplicates.Any())
                {
                    var channelNames = string.Join(", ", duplicates);

                    return new PrtgSensorErrorResult($"One or more channels were included multiple times in this sensor.  Duplicate channels: {channelNames}");
                }
            }

            return null;
        }

        private List<string> GetDuplicateChannels()
        {
            return Channels.GroupBy(r => r.Name, StringComparer.OrdinalIgnoreCase)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToList();
        }
    }
}