namespace PrtgSharp.ChannelProperties
{
    /// <summary>
    /// Define if the value is a float. Default is 0 (no). If set to 1 (yes), use a dot as decimal separator in values. Note: Define decimal places with the <DecimalMode> element.
    /// </summary>
    internal class ValueDataTypeProperty : ChannelProperty
    {
        public static ValueDataTypeProperty Integer => new ValueDataTypeProperty("0");
        public static ValueDataTypeProperty Float => new ValueDataTypeProperty("0");

        private ValueDataTypeProperty(string value)
            : base("float", value) { }
    }
}