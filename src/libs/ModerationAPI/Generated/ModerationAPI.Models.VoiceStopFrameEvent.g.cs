
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceStopFrameEvent
    {
        /// <summary>
        /// 
        /// </summary>
        Stop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceStopFrameEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceStopFrameEvent value)
        {
            return value switch
            {
                VoiceStopFrameEvent.Stop => "stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceStopFrameEvent? ToEnum(string value)
        {
            return value switch
            {
                "stop" => VoiceStopFrameEvent.Stop,
                _ => null,
            };
        }
    }
}