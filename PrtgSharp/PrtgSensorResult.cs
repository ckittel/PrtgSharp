using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace PrtgSharp
{
    public abstract class PrtgSensorResult : IPrtgSensorResult
    {
        protected SensorText Text { get; }
        protected IEnumerable<IChannel> Channels { get; }

        private const int MaxNumberOfChannels = 50;

        protected PrtgSensorResult()
            : this (null, null) { }

        protected PrtgSensorResult(SensorText text)
            : this (text, null) { }

        protected PrtgSensorResult(SensorText text, IEnumerable<IChannel> channels)
        {
            Text = text;
            Channels = channels;
        }

        public static PrtgSensorSuccessResult Success(string sensorMessage)
        {
            return new PrtgSensorSuccessResult(sensorMessage);    
        }

        public static PrtgSensorSuccessResult Success(string sensorMessage, IEnumerable<IChannel> channels)
        {
            return new PrtgSensorSuccessResult(sensorMessage, channels);
        }

        public static PrtgSensorSuccessResult Success(IEnumerable<IChannel> channels)
        {
            return new PrtgSensorSuccessResult(channels);
        }

        public static PrtgSensorErrorResult Failed(string sensorErrorMessage)
        {
            return new PrtgSensorErrorResult(sensorErrorMessage);
        }

        public static PrtgSensorErrorResult Failed(SensorText sensorErrorMessage)
        {
            return new PrtgSensorErrorResult(sensorErrorMessage);
        }

        public XElement Serialize()
        {
            var errorResult = ValidateOrGetErrorResult();

            if (errorResult != null)
            {
                return errorResult.Serialize();
            }

            return new XElement("prtg",
                Text?.ToXElement(),
                SerializeResult());
        }

        protected abstract IEnumerable<XElement> SerializeResult();

        private PrtgSensorErrorResult ValidateOrGetErrorResult()
        {
            if (Channels != null)
            { 
                var duplicates = GetDuplicateChannels();
                if (duplicates.Any())
                {
                    var channelNames = string.Join(", ", duplicates);

                    return PrtgSensorResult.Failed($"One or more channels were included multiple times in this sensor.  Duplicate channels: {channelNames}");
                }

                if (Channels.Count() > MaxNumberOfChannels)
                {
                    return PrtgSensorResult.Failed($"Cannot have more than {MaxNumberOfChannels} channels defined for a sensor; this sensor has {Channels.Count()}.");
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