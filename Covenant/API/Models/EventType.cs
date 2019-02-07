// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EventType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventType
    {
        [EnumMember(Value = "Normal")]
        Normal,
        [EnumMember(Value = "Download")]
        Download
    }
    internal static class EventTypeEnumExtension
    {
        internal static string ToSerializedValue(this EventType? value)
        {
            return value == null ? null : ((EventType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this EventType value)
        {
            switch( value )
            {
                case EventType.Normal:
                    return "Normal";
                case EventType.Download:
                    return "Download";
            }
            return null;
        }

        internal static EventType? ParseEventType(this string value)
        {
            switch( value )
            {
                case "Normal":
                    return EventType.Normal;
                case "Download":
                    return EventType.Download;
            }
            return null;
        }
    }
}
