[![Build Status](https://travis-ci.org/ckittel/PrtgSharp.svg?branch=master)](https://travis-ci.org/ckittel/PrtgSharp)

# PrtgSharp

A library useful in creating well-formed XML responses for Custom Sensors in [PRTG](https://www.paessler.com/prtg). Specifically it can be used in both the "Advanced EXE/Script Sensor" and "Advanced HTTP Data Sensors."

It's based on the [PRTG API documentation](https://prtg.paessler.com/api.htm?username=demo&password=demodemo&tabid=7) for PRTG Network Monitor 16.4.x. It contains every sensor and channel property/element and does reduimentary sanity checking of values & final results.  

The library allows you to feed it `Channel` data (and related `ChannelProperties`) and emits an `XElement` following the defined XML spec.

## Obtaining

    PM> Install-Package PrtgSharp.Core -Pre

## Example Usages

### Success
```csharp
var channels = new List<IChannel>
{
    new Channel("Last Scan Duration", 
                142.5f, 
                new[] { ValueUnitProperty.TimeSeconds, SpeedValueDisplayTimeProperty.Minute }),

    new Channel("Velocity (unladen swallow)", 
                11, 
                new [] { ValueUnitProperty.Custom, new CustomValueUnitProperty("M/Sec") }),

    new Channel("Widget Size", 
                415, 
                new [] { ValueUnitProperty.BytesDisk })
};

var rpt = new PrtgSensorSuccessResult("Everything Looks Awesome!", channels);
var output = rpt.SerializeToXElement().ToString();
```
Produces the following XML in `output`
```xml
<prtg>
  <text>Everything Looks Awesome!</text>
  <result>
    <channel>Last Scan Duration</channel>
    <value>142.5</value>
    <unit>TimeSeconds</unit>
    <speedtime>Minute</speedtime>
    <float>1</float>
  </result>
  <result>
    <channel>Velocity (unladen swallow)</channel>
    <value>11</value>
    <unit>Custom</unit>
    <customunit>M/Sec</customunit>
    <float>0</float>
  </result>
  <result>
    <channel>Widget Size</channel>
    <value>415</value>
    <unit>BytesDisk</unit>
    <float>0</float>
  </result>
</prtg>
```

### Failure
```csharp
var rpt = new PrtgSensorErrorResult("It's all gone horribly wrong :(");
var output = rpt.SerializeToXElement().ToString();
```
Produces the following XML in `output`
```xml
<prtg>
  <text>It's all gone horribly wrong :(</text>
  <error>1</error>
</prtg>
```
            
## Future Features

* Logging Infrastructure to help debug/monitor
* EXE-specific Features
  * Capturing of command line parameters
  * Capturing of environment variables
* HTML-specific Helpers
