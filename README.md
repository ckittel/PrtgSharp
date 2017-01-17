# PrtgSharp

A library useful in creating well-formed XML responses for Custom Sensors in [PRTG](https://www.paessler.com/prtg). Specifically it can be used in both the "Advanced EXE/Script Sensor" and "Advanced HTTP Data Sensors."

It's based on the [PRTG API documentation](https://prtg.paessler.com/api.htm?username=demo&password=demodemo&tabid=7) for PRTG Network Monitor 16.4.x. It contains every sensor and channel property/element and does reduimentary sanity checking of values & final results.  

The library allows you to feed it `Channel` data (and related `ChannelProperties`) and emits an `XElement` following the defined XML spec.

## Obtaining

    PM> Install-Package PrtgSharp.Core -Pre

## Future Features

* Logging Infrastructure to help debug/monitor
* EXE-specific Features
  * Capturing of command line parameters
  * Capturing of environment variables
* HTML-specific Helpers
